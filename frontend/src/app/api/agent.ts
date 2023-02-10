import axios, { AxiosResponse } from "axios";
import { resolve } from "path";
import { Exam } from "../models/exam";

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay)
    })
}

axios.defaults.baseURL = "http://localhost:5113/api";

axios.interceptors.response.use(async response => {
    try {
        await sleep(1000);
        return response;
    } catch (error) {
        console.log(error);
        return await Promise.reject(error);
    }
})

const responseBody = <T> (response: AxiosResponse<T>) => response.data;

const requests = {
  get: <T> (url: string) => axios.get<T>(url).then(responseBody),
  post: <T> (url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
  put: <T> (url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
  del: <T> (url: string) => axios.delete<T>(url).then(responseBody)
};

const Exams = {
    list: () => requests.get<Exam[]>('/Exam'),
    details: (id: string) => requests.get<Exam>(`/Exam/${id}`),
    create: (exam: Exam) => axios.post<void>(`/Exam`, exam),
    update: (exam: Exam) => axios.put<void>(`/Exam/${exam.id}`, exam),
    delete: (id: string) => axios.delete<void>(`/Exam/${id}`)
}

const agent = {
    Exams
}

export default agent;