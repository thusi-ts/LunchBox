import React, { Component } from 'react';
import { Link } from 'react-router-dom';


export default class Navigation extends Component {
    render() {
        return (
            <nav>
                <ul>
                    <li className="fa fa-utensils">
                        <Link to="/pages">Find mad</Link>
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
