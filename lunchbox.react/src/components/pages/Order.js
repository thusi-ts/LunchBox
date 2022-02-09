import React, { Component } from 'react'
import { render } from 'react-dom';

export default class Order extends Component {

    constructor(props){
        super(props);

        this.state = { active: []} 

        this.toggleMenu = this.toggleMenu.bind(this);
    }
    // https://www.w3schools.com/howto/howto_js_close_list_items.asp

    toggleMenu = (e) => {

        //const active = this.state.active ? false : true;

        console.log(e);

    // function that will toggle active/false
       /* this.setState((prevState) => {
        active: !prevState.active
        }); */
    }

    render() {
        return (
            <div className='form oders'>
                <h1 className="title">Order</h1>
                <div className="main-title">Produkter</div>

                <ul className='list'>
                <li>
                    <OrderHeader name={'items-1'} display={true} toggleMenu = {this.toggleMenu}  />
                </li>
                <li>
                    <OrderHeader name={'items-2'} display={true} toggleMenu = {this.toggleMenu}  />
                </li>
                <li>
                    <OrderHeader name={'items-13'} display={true} toggleMenu = {this.toggleMenu}  />
                </li>
                </ul>
            </div>
        )
    }
}

const OrderHeader = (props) => {
    return (<div >
                <div className='order-header' onClick={(e) => props.toggleMenu(e, active)}>Test</div>
                <OrderDetails name={props.name} display={true} toggleMenu={props.toggleMenu} />
            </div>)
} 

const OrderDetails = (props) => {

    let details;
    let active = props.active ? false : true;
    console.log(active);

    if (active) {
        details = <div className='order-details'  {props.name} </div>
    } else {
        details = <div className='order-details'> </div>
    }

    return <div> {details} </div>
} 