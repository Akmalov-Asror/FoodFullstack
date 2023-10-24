import React, { useState, useEffect } from 'react'
import { useNavigate } from 'react-router-dom'
import "./Register.scss"
import BacdropImage from '../../Assets/Images/photo_2023-10-19_07-28-40.jpg'
import { NavLink } from 'react-router-dom'
import Delay from '../Delay/Delay'
export default function Register() {
    const navigate = useNavigate();
    const [isLoading, setIsLoading] = useState(true);
    const [phoneNumber, setPhonenNumber] = useState("")
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")
    const allowedCharacters = /[0-9+]/;
    const postLoginData = async () => {
        ///////////
    }
    function handleInput(e){
        let inputPhoneNumber = e.target.value;

       
    inputPhoneNumber = inputPhoneNumber.replace(/[^0-9]+/g, '');

    // Format the phone number
    let formattedPhoneNumber = '';
    if (inputPhoneNumber.length > 0) {
      formattedPhoneNumber = `+${inputPhoneNumber.slice(0, 3)} (${inputPhoneNumber.slice(
        3,
        5
      )}) ${inputPhoneNumber.slice(5, 8)}-${inputPhoneNumber.slice(8, 10)}-${inputPhoneNumber.slice(10, 12)}`;
    }
    
        setPhonenNumber(formattedPhoneNumber);
    }


    function handleKeyDown(e){
        if (e.key === 'Backspace') {
            setPhonenNumber("")
            return;
          }
          
        
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
            {(!isLoading) ? <Delay/> : <>
            <img className='login-image' src={BacdropImage} alt="LoginImage" />
            <div>
                <section>
                    <div className="form-box">
                        <div className="form-value">
                            <form onSubmit={postLoginData}>
                                <h2>Register</h2>
                                <div className="inputbox">
                                    <input  onKeyDown={handleKeyDown} value={phoneNumber} onChange={(i) => handleInput(i)}  type="tel" name="numberr" id="" />
                                    <label for="numberr">Phone number</label>
                                </div>
                                <div className="inputbox">
                                    <input onChange={(i) => setEmail(i.target.value)} required type="email" name="email" id="" />
                                    <label for="email">Email</label>
                                </div>
                                <div className="inputbox">
                                    <input onChange={(i) => setPassword(i.target.value)} required type="password" name="password" id="" />
                                    <label for="password">Password</label>
                                </div>
                                <div className="forget">
                                    <label>Forgot password? <a>New password</a></label>
                                </div>
                                <button type='submit'>Log in</button>
                                <div className="register">
                                    <p>No account? <NavLink to='/' className={`${({ isActive, isPending }) => isPending ? "pending" : isActive ? "active" : ""} a`}>Log in</NavLink></p>
                                </div>
                            </form>
                        </div>
                    </div>
                </section>
            </div>
            </>}
        
        </div>
    )
}
