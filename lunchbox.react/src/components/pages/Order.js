import React, { Component } from 'react'
import { render } from 'react-dom';

export default class Order extends Component {

    constructor(props){
        super(props);

        this.state = { active: false} 

        this.toggleMenu = this.toggleMenu.bind(this);
    }
    // https://www.w3schools.com/howto/howto_js_close_list_items.asp

    toggleMenu = () => {

        const active = this.state.active ? false : true;

        console.log(active);

    // function that will toggle active/false
        this.setState((prevState) => {
        active: !prevState.active
        });
    }

    render() {
        return (
            <div className='form oders'>
                <h1 className="title">Order</h1>
                <div className="main-title">Produkter</div>

                <ul className='list'>
                <li>
                    <OrderHeader display={true}  />
                </li>
                <li>
                    <OrderHeader display={true}  />
                </li>
                <li>
                    <OrderHeader display={true}  />
                </li>
                </ul>
            </div>
        )
    }
}

const OrderHeader = (props) => {
    return <OrderDetails display={true} onClick={toggleMenu} />
} 

const OrderDetails = (props) => {
    if (props.display) {
        return <div className='items-1'>infor 1</div>
    }
} 