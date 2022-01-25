import React, { Component } from 'react';
import { Link } from 'react-router-dom';


export default class Navigation extends Component {
    render() {
        return (
            <nav>
                <ul>
                    <li className="fa fa-utensils">
                        <Link to="/pages/index">Find mad</Link>
                    </li>
                    <li className="fa fa-receipt">
                        <Link to="/pages/register">Ordrer</Link>
                    </li>
                    <li className="fa fa-info-circle">
                        <Link to="/pages/info">Info</Link>
                    </li>
                    <li className="fa fa-user">
                        <Link to="/pages/login">Min konto</Link>
                    </li>
                </ul>
            </nav>        
        )
    }
}






<nav>
                    	<a onclick="link_navigation('index');"><i class="fa fa-utensils"></i> Find mad</a>
                    	<a onclick="link_navigation('orders');"><i class="fa fa-receipt"></i> Ordrer</a>
                        <a onclick="link_navigation('info');"><i class="fa fa-info-circle"></i> Info</a>
                    	<a onclick="link_navigation('user');"><i class="fa fa-user"></i> Min konto</a>
                    </nav>