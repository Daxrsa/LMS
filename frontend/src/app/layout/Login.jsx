/*import React, {useState} from "react"; // to capture values


export const Login = (props) => {
    const [email,setEmail]= useState(''); //initial values are empty
    const [password,setPassword]= useState('');

    //capturing data when user submits the form

    const handleSubmit=(e)=>{
        e.preventDefault(); //to not lose our state when reloading
        console.log(email);

    }
    return (
        <>
        <div className="auth-form-contanier">
        <form className="login-form"onSubmit={handleSubmit}>
            <label htmlFor ="email">email</label>
            <input value={email} onChange={(e)=>setEmail(e.target.value)} type="Email" placeholder= "youremail@gmail.com"
            id="Email" name="Email"/>
            <label htmlFor ="password">password</label>
            <input value={password} onChange={(e)=>setPassword(e.target.value)} type="Password" placeholder= "********" 
            id="Password" name="Password"/>
            <button>Log In</button>
        </form>
        <button className="link-btn"onClick={()=>props.onFormSwitch('register')}>Don't have an account? Register here.</button>
    </div></>
    )
}*/