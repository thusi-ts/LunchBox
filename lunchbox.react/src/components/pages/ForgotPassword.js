import React, { Component } from 'react'

export default class ForgotPassword extends Component {

    constructor(props){
        
        super(props);
        this.state = {
            user : {
                mail: '',
            }
        };

        this.changeHandler = this.changeHandler.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    changeHandler = (e) => {
        const name = e.target.name;
        const value = e.target.value;

        console.log(this.state.user+" "+name);

        this.setState({
            user : {
                ...this.state.user, 
                [name] : value,
            }
        });
    }

    handleSubmit = (event) => {
        event.preventDefault();
        console.log(this.state.user);
    };

    render() {
        return (
            <div className="forgotpassword form">
                <h1>Glemt password</h1>
                <form onSubmit={this.handleSubmit} >
                
                <p className="row">
                    <label htmlFor="mail">E-mail</label>
                    <input 
                        type="email" 
                        name="mail" 
                        onChange={this.changeHandler}
                        required="" 
                    />
                </p>
                <p>
                    <input 
                        type="submit" 
                        class="submitbtn"
                        value="Send" 
                    />
                </p>
                </form>
            </div>
        )
    }
}