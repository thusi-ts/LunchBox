import React, { Component } from 'react'
import { Link } from 'react-router-dom';

export default class Login extends Component {

    constructor(props){
        
        super(props);
        this.state = {
            login : {
                username: '',
                password: '',
            }
        };

        this.changeHandler = this.changeHandler.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        
    }

    changeHandler = (e) => {
        const name = e.target.name;
        const value = e.target.value;

        console.log(this.state.login+" "+name);

        this.setState({
            login : {
                ...this.state.user, 
                [name] : value,
            }
        });
    }

    handleSubmit = (event) => {
        event.preventDefault();
        console.log(this.state.login);
    };

    render(){
        return (
            <div className="login form">
                <h1 className="title">Bruger</h1>

                <div className="">
                <form onSubmit={this.handleSubmit} >
                    
                    <p>
                        <label htmlFor="username">brugernavn:</label>
                        <input 
                            type="text" 
                            name="username" 
                            value={this.state.login.username} 
                            onChange={this.changeHandler}
                            required 
                        />
                    </p>
                    <p>
                        <label htmlFor="password">Vælg adgangskode:</label>
                        <input 
                            type="password" 
                            name="password" 
                            placeholder="Min. 4 tegn" 
                            value={this.state.login.password} 
                            onChange={this.changeHandler}
                            required 
                        />
                    </p>
                     <p>
                        <input 
                            type="submit" 
                            value="Login" 
                            className="submitbtn" 
                        />
                    </p>
                    </form>
                </div>
                <div>
                    <ul className='vlink'>
                        <li> <i className="fas fa-basketball-hoop"></i><Link to="/pages/register">Opret konto</Link> </li>
                        <li> <i className="fas fa-basketball-hoop"></i><Link to="/pages/ForgotPassword">Glemt adgangskoden ?</Link> </li>
                    </ul>
                </div>
            </div>
        )
    }
}