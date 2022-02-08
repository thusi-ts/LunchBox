import React, { Component } from 'react';
import { Link } from 'react-router-dom';

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faCoffee  } from '@fortawesome/free-solid-svg-icons'
//import { utensils} from '@fortawesome/free-solid-svg-icons'
//import { FaInfoCircle } from '@fortawesome/free-solid-svg-icons'
//import { apple } from '@fortawesome/free-solid-svg-icons'


const myfood = <FontAwesomeIcon icon={faCoffee} style={{ color: 'white' }} />
const myaccount = <FontAwesomeIcon icon={faCoffee} style={{ color: 'white' }} />
//const info = <FontAwesomeIcon icon={FaInfoCircle} />
const info = <FontAwesomeIcon icon={faCoffee} style={{ color: 'white' }} />
const register = <FontAwesomeIcon icon={faCoffee} style={{ color: 'white' }} />

export default class Navigation extends Component {
    render() {
        return (
            <nav>
                <ul>
                    <li> {myfood} <Link to="/pages">Find mad</Link> </li>
                    <li> {myaccount} <i className="fas fa-basketball-hoop"></i><Link to="/pages/order">Ordrer</Link> </li>
                    <li> {info} <Link to="/pages/info">Info</Link> </li>
                    <li> {register} <Link to="/pages/login">Min konto</Link> </li>
                </ul>
            </nav>        
        )
    }
}
