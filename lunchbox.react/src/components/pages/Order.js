import React, { Component } from 'react'
import { render } from 'react-dom';

export default class Order extends Component {

    constructor(props){
        super(props);

        this.state = {
            /*
            list: [
              { id: '1', active: 42 },
              { id: '2', age: 33 },
              { id: '3', age: 68 },
            ],
            */
           orderList : []
          };

        this.toggleMenu = this.toggleMenu.bind(this);
    }

    toggleMenu = (name) => {

        
        let newOrderList;
       // const orderList = this.state.orderList.slice();

       const orderList = [];

        console.log(this.state);

        const result = orderList.find( ({ name }) => name === name );

        

        let active = true;
        if(result === undefined){
            newOrderList = orderList.push(...orderList, {name: name, value: true});
        }

        console.log(newOrderList);

        this.setState({
            orderList : newOrderList
        });


        

       // console.log(orderList);
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
                    <OrderHeader name={'items-3'} display={true} toggleMenu = {this.toggleMenu}  />
                </li>
                </ul>
            </div>
        )
    }
}

const OrderHeader = (props) => {
    return (<div >
                <div className='order-header' onClick={(e) => props.toggleMenu(props.name)}>Test</div>
                <OrderDetails name={props.name} display={true} toggleMenu={props.toggleMenu} />
            </div>)
} 

const OrderDetails = (props) => {

    let details;
    let active = props.active ? false : true;

    if (active) {
        details = <div className='order-details'>  {props.name} </div>
    } else {
        details = <div className='order-details'> </div>
    }

    return (<div> {details} </div>)
} 