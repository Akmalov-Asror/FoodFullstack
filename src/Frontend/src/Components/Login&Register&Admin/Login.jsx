import React, {useState, useEffect, Profiler} from 'react'
import { useNavigate } from 'react-router-dom'
import Delay from '../Delay/Delay'
import BacdropImage from '../../Assets/Images/photo_2023-10-19_07-28-40.jpg'
import "./Login.scss"
import { NavLink } from "react-router-dom";
import Porfile from '../Profile/Porfile'
export default function Login() {
    const navigate = useNavigate();
    const [isLoading, setIsLoading] = useState(true);

    const postLoginData = async()=>{

    }
    useEffect(()=>{
        setIsLoading(false)
        const delay = 1000;
        <Delay />
        const redirectTimeout = setTimeout(() => {
          setIsLoading(true)
        }, delay);
    
        return () => {
          clearTimeout(redirectTimeout);
        };
      },[])
  return (
    <div>
        {(!isLoading)
         ?
         <Delay/> 
        :
         <>
                <img className='login-image' src={BacdropImage} alt="LoginImage" />
      <div>
        <section>
            <div className="form-box">
                <div className="form-value">
                    <form onSubmit={postLoginData}>
                        <h2>Login</h2>
                        <div className="inputbox">
                            <input required type="email" name="email" id="" />
                            <label for="email">Email</label>
                        </div>
                        <div className="inputbox">
                            <input required type="password" name="password" id="" />
                            <label for="password">Password</label>
                        </div>
                        <div className="forget">
                        <label>Forgot password? <NavLink to='/forgotpasswword' className={`${({ isActive, isPending }) => isPending ? "pending" : isActive ? "active" : ""} a`} >New password</NavLink></label>
                        </div>
                        <button type='submit'>Log in</button>
                        <div className="register">
                            <p>No account? <NavLink to='/register' className={`${({ isActive, isPending }) => isPending ? "pending" : isActive ? "active" : ""} a`}>Register</NavLink></p>
                        </div>
                    </form>
                     <NavLink  to='/'  className={`${({ isActive, isPending }) => isPending ? "pending" : isActive ? "active" : ""} LinkToHome`}><p>Home page</p> <div><i class="bi bi-arrow-right"></i></div></NavLink>

                </div>
            </div>
        </section>
      </div>
        </>}
    </div>
  )
}
