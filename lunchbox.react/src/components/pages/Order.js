import React, { Component } from 'react'

export default class Order extends Component {

    constructor(props){
        super(props);

        this.state = {
           orderList : [
               {index: 'items1', name : 'test1', display: false},
               {index: 'items2', name : 'test2', display: false},
               {index: 'items3', name : 'test3', display: false}
           ]
        };

        this.toggleMenu = this.toggleMenu.bind(this);
    }

    toggleMenu = (index) => {

        let orderList = this.state.orderList.slice();
        let newOrderList = [];

        orderList.forEach((x) => {
            if(x.index === index){
                newOrderList.push({index: x.index, name : x.name, display: x.display ? false : true});
            }else{
                newOrderList.push(x);
            }
        });

        this.setState({
            orderList : newOrderList
        });
    }

    render() {
        return (
            <div className='form oders'>
                <h1 className="title">Order</h1>
                <div className="main-title">Produkter</div>

                <ul className='list'>
                    {this.state.orderList.map((x) => ( 
                        <li key={x.index}>
                            <OrderHeader index={x.index} name={x.name} display={x.display} toggleMenu = {this.toggleMenu} />
                        </li>
                    ))}
                </ul>
            </div>
        )
    }
}

const OrderHeader = (props) => {  
    return (
        <div>
            <div className='order-header' onClick={(e) => props.toggleMenu(props.index)}>{props.name}</div>
            <OrderDetails index={props.index} name={props.name} display={props.display} toggleMenu={props.toggleMenu} />
        </div>
    )
} 

const OrderDetails = (props) => {

    let details;

    if (props.display) {
        details = <div index={props.index} className='order-details'>  {props.name} </div>
    } else {
        details = <div index={props.index} className='order-details'> </div>
    }
    return (<div> {details} </div>)
} 