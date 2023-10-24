import React, { useEffect, useState } from 'react'
import { NavLink, useLocation, useNavigate } from 'react-router-dom'
import Delay from '../Delay/Delay';
import "./Sitebar.scss"
export default function SiteBar() {
  const navigate = useNavigate();
  const location = useLocation()
  const [isLoading, setIsLoading] = useState(true)
  const [activeLink, setactiveLink] = useState(false)
  const [ userEmail, setUserEmail] = useState("")

  const [sitebar, setSitebar] = useState([
    {
      icon: "bi bi-list",
      id: 1,
      path: "/history",
    },
    {
      icon: "bi bi-house",
      id: 2,
      path: "/",
    },
    {
      icon: "bi bi-gear",
      id: 3,
      path: "/setting",
    },
    {
      icon: "bi bi-pie-chart",
      id: 4,
      path: "/piechard",
    },
    {
      icon: "bi bi-chat-square",
      id: 5,
      path: "/chat",
    },
    {
      icon: "bi bi-cart3",
      id: 6,
      path: "/shop",
    },
    {
      icon: "bi bi-person",
      id: 7,
      path: "/login",
      profile_paht: "/myaccount"
    },
  ])
  const [sitebarMob, setSitebarMob] = useState([
    {
      icon: "bi bi-list",
      id: 1,
      path: "/history",
    },
    {
      icon: "bi bi-pie-chart",
      id: 2,
      path: "/piechard",
    },
    {
      icon: "bi bi-house",
      id: 3,
      path: "/",
    },
    {
      icon: "bi bi-cart3",
      id: 6,
      path: "/shop",
    },
    {
      icon: "bi bi-person",
      id: 7,
      path: "/login",
    },
  ])
  function delay(evt, iteam) {
    setactiveLink(true)
    if(evt === '/shop'){
      sessionStorage.setItem("shop" , true)
    }
    if(iteam === "/myaccount") {
      sessionStorage.setItem("account", true)
    }
  }

  useEffect(()=>{
    localStorage.setItem("email", "aziz@gmail.com")
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
  useEffect(()=>{
    const email = localStorage.getItem("email")
    if(email.length !== "" || email !== undefined || email !== null){
        setUserEmail(email)
    }
  },[])

  return (
    <div>
      {!isLoading ? <Delay /> : <div className='row siteBar Decktop'>
        {
          sitebar?.map((iteam, index) => {
            const isActive2 = location.pathname === iteam.path;
            return (
              <div key={index} className={`col-2 col-sm-12 ${isActive2 ? 'active-link' : ''}`}>
                <div>
                  <NavLink to={`${iteam.path === "/login" && userEmail.length > 0 ? iteam.profile_paht : iteam.path}`} onClick={()=>{delay(iteam.path, iteam.profile_paht)}} className={`${({ isActive, isPending }) => isPending ? "pending" : isActive ? `active` : ``} `}>
                    <i className={iteam.icon}></i>
                  </NavLink>
                </div>
              </div>
            )
          })
        }
      </div>}

      {!isLoading ? <Delay /> : <div className='siteBar Modile'>
        {
          sitebarMob?.map((iteam, index) => {
            const isActive2 = location.pathname === iteam.path;

            return (
              <div key={index}  className={`siteBarCard ${isActive2 ? 'active-link' : ''}`}>
                <div>
                  <NavLink to={`${iteam.path}`} className={`${({ isActive, isPending }) => isPending ? "pending" : isActive ? "active" : "text-white link"} `}>
                    <i className={iteam.icon}></i>
                  </NavLink>
                </div>
              </div>
            )
          })
        }
      </div>}


    </div>
  )
}
