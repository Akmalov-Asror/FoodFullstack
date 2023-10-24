import React, { useState, useEffect } from 'react'
import Home from '../Home/Home'
import "./Shop.scss"
import Delay from '../Delay/Delay'
import { useNavigate } from 'react-router-dom'
import Logo from "../../Assets/Images/English breakfast-pana 1.png"
export default function Shop() {
    const navigate = useNavigate()
    const [priceFoods, setPriceFoods] = useState([])
    const [offcanvas, setOffcanvas] = useState(false)
    const [paymentMethod, setPaymentMethod] = useState(true)
    const [paymentMethodBtn, setPaymentMethodBtn] = useState("btn1")
    const [selectVal, setSelectVal] = useState("Diner In")
    const [open, setOpen] = useState(false)
    // input values
    const [CardNumberVal, setCardNumberVal] = useState('')
    const [CwwCardVal, setCwwCardVal] = useState('')
    const [tableNoVal, setTableNoVal] = useState('')
    const [CardFullName, setCardFullName] = useState('')
    const [CardFullDate, setCardFullDate] = useState('')
    // input values
    const [isLoading, setIsLoading] = useState(true);
    const [activeButton, setActiveButton] = useState("btn1")
    const [purchasedFood, setPurchasedFood] = useState([
        {
            img: "https://www.mashed.com/img/gallery/the-best-new-fast-food-menu-items-weve-tried-in-2023-so-far/l-intro-1682446897.jpg",
            name: "Lavash",
            price: 220,
            dex: "Spicy seasoned seafood noodles",
            count: 1,
        },
        {
            img: "https://www.mashed.com/img/gallery/the-best-new-fast-food-menu-items-weve-tried-in-2023-so-far/l-intro-1682446897.jpg",
            name: "Lavash",
            price: 224340,
            dex: "Spicy seasoned seafood noodles",
            count: 1,
        },
        {
            img: "https://www.mashed.com/img/gallery/the-best-new-fast-food-menu-items-weve-tried-in-2023-so-far/l-intro-1682446897.jpg",
            name: "Lavash",
            price: 25320,
            dex: "Spicy seasoned seafood noodles",
            count: 1,
        },
        {
            img: "https://www.mashed.com/img/gallery/the-best-new-fast-food-menu-items-weve-tried-in-2023-so-far/l-intro-1682446897.jpg",
            name: "Lavash",
            price: 2250,
            dex: "Spicy seasoned seafood noodles",
            count: 1,
        },
    ])
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
    useEffect(() => {
        const prices = purchasedFood.map(item => item.price);
        setPriceFoods(prices);
    }, []);

    function closeOffcanvas() {
        sessionStorage.setItem("shop", false)
        navigate("/")
    }
    function noFoods() {
        navigate("/")
    }
    function activeLinkBtn(iteam, index) {
        setSelectVal(index)
        setActiveButton(iteam)
    }
    function payment() {
        setPaymentMethod(false)
    }
    function paymentMethodCard(iteam) {
        setPaymentMethodBtn(iteam)
    }
    function choosFood(value) {
        if (value !== undefined) {
            localStorage.setItem("sort", value)
            setSelectVal(value)
        }
        else {
            localStorage.setItem("sort", "")
            setSelectVal("Diner In")
        }
        setOpen(false)
    }
    function CardNumber(i) {
        let input = i.target.value.replace(/\D/g, '');
        const cardNumberRegex = /(\d{4})(?=\d)/g;
        input = input.replace(cardNumberRegex, '$1 ');

        i.target.value = input;
        setCardNumberVal(input)

    }
    function cwwCard(i) {
        let input = i.target.value.replace(/\D/g, '');
        setCwwCardVal(input)
    }
    function tablePass(i) {
        let input = i.target.value.replace(/\D/g, '');
        setTableNoVal(input)
    }
    function CardName(i) {
        setCardFullName(i.target.value)
    }
    function CardDate(i) {
        setCardFullDate(i.target.value)
    }
    function pay() {
        
    }
    return (
        <div >
            {!isLoading ? <Delay /> : <>
                <Home />

                <div className={`${offcanvas === "true" ? "active-filter" : ""} offcanvas-filter`} onClick={closeOffcanvas}>
                </div>
                <div className={`${offcanvas === "true" ? "active-offcanvas" : ""} offcanvass`}>
                    {purchasedFood.length === 0 || purchasedFood === undefined || purchasedFood === null ? <>
                        <div className='emptyBox'>
                            <img src={Logo} alt="logo" />
                            <button onClick={noFoods}>To Order</button>
                        </div>
                    </> : <>
                        {paymentMethod ? <>
                            <div className='purchased-foods container'>
                                <div className='order-div'>
                                    <div>
                                        <i onClick={()=>navigate('/')} className='bi bi-arrow-left'></i>
                                        <h4>Orders #34562</h4>
                                    </div>
                                    <div >
                                        <button className={`${activeButton === 'btn1' ? "activeButton" : ""}`} onClick={() => activeLinkBtn("btn1", "Diner In")}>Dine In</button>
                                        <button className={`${activeButton === 'btn2' ? "activeButton" : ""}`} onClick={() => activeLinkBtn("btn2", "To Go ")}>To Go</button>
                                        <button className={`${activeButton === 'btn3' ? "activeButton" : ""}`} onClick={() => activeLinkBtn("btn3", "Delivery")}>Delivery</button>
                                    </div>
                                </div>
                                <div className='product-table-head'>
                                    <div>
                                        <h6>Food</h6>
                                    </div>
                                    <div>
                                        <h6>Description</h6>
                                        <h6>Price</h6>
                                    </div>
                                </div>
                                {purchasedFood?.length > 0 ? purchasedFood?.map((iteam, index) => {
                                    return (
                                        <div className='product-purchase'>
                                            <div>
                                                <div style={{ backgroundImage: `url(${iteam.img})` }}>
                                                </div>
                                                <div>
                                                    <h6>{iteam.dex}</h6>
                                                    <h6>${priceFoods[index]}</h6>

                                                </div>
                                            </div>
                                            <div className='action-div'>
                                                <div>
                                                    <button>-</button>
                                                    <div>{iteam.count}</div>
                                                    <button>+</button>
                                                </div>
                                                <div>
                                                    <h6>
                                                        ${iteam.price}
                                                    </h6>
                                                </div>
                                            </div>
                                            <div className='comfirm-input'>
                                                <input placeholder='Order Note...' type="text" name="" id="" />
                                                <button><i className='bi bi-trash'></i></button>
                                            </div>
                                        </div>
                                    )
                                }) : <Delay />}
                                <div onClick={() => payment()} className='confirm-payment'><button>Continue to Payment</button></div>
                            </div>
                        </> : <>
                            <form onSubmit={pay} className='container paymentOffnavas'>
                                <div className='payment'>
                                    <h6>Payment</h6>
                                    <p>3 payment method available</p>
                                </div>

                                <div className='payment-method'>
                                    <button className={`${paymentMethodBtn === "btn1" ? "activeMethod" : ""}`} onClick={() => paymentMethodCard("btn1")}> <i className={`${paymentMethodBtn === "btn1" ? "verifyActive" : ""} bi bi-patch-check`}></i> <i className='bi bi-credit-card-2-front'></i> <p>Credit Card</p></button>
                                    <button className={`${paymentMethodBtn === "btn2" ? "activeMethod" : ""}`} onClick={() => paymentMethodCard("btn2")}> <i className={`${paymentMethodBtn === "btn2" ? "verifyActive" : ""} bi bi-patch-check`}></i> <i className='bi bi-paypal'></i> <p>Paypal</p></button>
                                    <button className={`${paymentMethodBtn === "btn3" ? "activeMethod" : ""}`} onClick={() => paymentMethodCard("btn3")}> <i className={`${paymentMethodBtn === "btn3" ? "verifyActive" : ""} bi bi-patch-check`}></i> <i className='bi bi-cash-coin'></i> <p>Cash</p></button>
                                </div>

                                <div className='inputs'>
                                    <div className='input-row-name'>
                                        <label className='input-label' htmlFor="name">Cardholder Name</label>
                                        <div className='input-icon-div'>
                                            <input required onChange={(i) => CardName(i)} className='input-verifiy' placeholder='Levi Ackerman' type="text" name="name" id="cardName" />
                                            <div className='input-icon'>{CardFullName.length < 3 ? <p className='text-danger mt-3'><i class="bi bi-exclamation-lg"></i></p> : <p className='text-success m-0 p-0'><i className='bi bi-patch-check'></i></p>}</div>
                                        </div>
                                    </div>
                                    <div className='input-row-card'>
                                        <label className='input-label' htmlFor="Card Number">Card Number</label>
                                        <div className='input-icon-div'>
                                            <input required value={CardNumberVal} maxLength={19} onChange={(i) => CardNumber(i)} className='input-verifiy' placeholder='2564 1421 0897 1244' type="text" name="Card Number" id="cardNum" />

                                            <div className='input-icon'>
                                                {CardNumberVal.length < 19 ? <p className='text-danger mt-3'><i class="bi bi-exclamation-lg"></i></p> : <p className='text-success m-0 p-0'><i className='bi bi-patch-check'></i></p>}
                                            </div>

                                        </div>

                                    </div>
                                    <div className='input-row-date'>
                                        <div>
                                            <label className='input-label' htmlFor="Expiration">Expiration Date</label>
                                            <div className='input-icon-div'>
                                                <input onChange={(i) => CardDate(i)} className='input-verifiy' placeholder='02/2022' type="date" name="Expiration" id="cardDate" />
                                                <div className='input-icon' style={{right: "45px"}}>
                                                    {CardFullDate.length < 10 ? <p className='text-danger mt-3'><i class="bi bi-exclamation-lg"></i></p> : <p className='text-success m-0 p-0'><i className='bi bi-patch-check'></i></p>}
                                                </div>
                                            </div>
                                        </div>
                                        <div>
                                            <label className='input-label' htmlFor="CVV">CVV</label>
                                            <div className='input-icon-div'>
                                                <input required value={CwwCardVal} maxLength={3} onChange={(i) => cwwCard(i)} className='input-verifiy' placeholder=' * * * ' type="password" name="CVV" id="cardCww" />
                                                <div className='input-icon'>
                                                    {CwwCardVal.length < 3 ? <p className='text-danger mt-3'><i class="bi bi-exclamation-lg"></i></p> : <p className='text-success m-0 p-0'><i className='bi bi-patch-check'></i></p>}
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div className='input-row-select'>

                                        <div className='select-row'>

                                            <div>
                                                <div className='select' type="button" data-bs-toggle="dropdown" aria-expanded="false">
                                                    {open ? <i className="bi bi-arrow-up-short"></i> : <i className="bi bi-arrow-down-short"></i>} <div><p>{selectVal}</p></div>
                                                    <ul className="dropdown-menu select-iteam">
                                                        <li><a class="dropdown-item" onClick={() => choosFood("Diner In")}>Diner In</a></li>
                                                        <li><a class="dropdown-item" onClick={() => choosFood("To Go")}>To Go</a></li>
                                                        <li><a class="dropdown-item" onClick={() => choosFood("Delivery")}>Delivery</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                        <div>
                                            <label className='input-label' htmlFor="Table">Table no</label>
                                            <div className='input-icon-div'>
                                                <input required value={tableNoVal} maxLength={3} onChange={(i) => tablePass(i)} className='input-verifiy' placeholder='140' type="text" name="Table" id="cardTable" />
                                                <div className='input-icon'>
                                                    {tableNoVal.length < 3 ? <p className='text-danger mt-3'><i class="bi bi-exclamation-lg"></i></p> : <p className='text-success m-0 p-0'><i className='bi bi-patch-check'></i></p>}
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div className='confirm-buy'><button onClick={() => setPaymentMethod(true)}>Cancel</button> <button onClick={pay} type='button'>Confirm Payment</button></div>

                            </form>


                        </>}

                    </>}

                </div>
            </>}
        </div >
    )
}
