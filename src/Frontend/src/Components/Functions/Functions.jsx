import Reac, { useState, useEffect } from 'react'
import { useNavigate } from 'react-router-dom';
import Delay from '../Delay/Delay';
import Home from '../Home/Home';
import "./Functions.scss"
export default function Functions() {
    const navigate = useNavigate()
    const [isLoading, setIsLoading] = useState(true);
    const [offcanvas, setOffcanvas] = useState(false)


    function closeOffcanvas() {
        sessionStorage.setItem("shop", false)
        navigate("/")
    }
    function bootstrapBnt() {
        let cur = sessionStorage.getItem("shop")
        setOffcanvas(true)
        if (cur !== "") {
            setOffcanvas(cur)
        }
    }
    useEffect(() => {
        const redirectTimeout = setTimeout(() => {

            bootstrapBnt()
        }, 2000)
        return () => {
            clearTimeout(redirectTimeout);
        };
    }, [])
    useEffect(() => {
        setIsLoading(false)
        const delay = 1000;
        <Delay />
        const redirectTimeout = setTimeout(() => {
            setIsLoading(true)
        }, delay);

        return () => {
            clearTimeout(redirectTimeout);
        };
    }, [])
    return (

        <div>
            {!isLoading ? <Delay /> : <>
                <Home />
                <div className={`${offcanvas === "true" ? "active-filter" : ""} offcanvas-filter`} onClick={closeOffcanvas}>
                </div>
                <div className={`${offcanvas === "true" ? "active-offcanvas" : ""} offcanvass`}>
                    ckdsckds
                </div>
            </>}

        </div>
    )
}
