import { useEffect } from "react";
import { BrowserRouter as Router, Routes, Route, Navigate, useLocation } from "react-router-dom";



import Header from "./components/Header";
import Splash from "./components/Splash";
import Navigation from "./components/Navigation";

// pages
import Index from "./components/pages/Index";
import Info from "./components/pages/Info";
import ForgotPassword from "./components/pages/ForgotPassword";
import Login from "./components/pages/Login";
import Register from "./components/pages/Register";
import Order from "./components/pages/Order";



function App() {

  useEffect(() => { console.log('1');

    setTimeout(() => { 
      <Navigate to='/pages'  />
    }, 5000)
  });

  //const location = useLocation();

  //console.log(location);

  //https://medium.com/@arashdeeps2004/splash-screen-in-react-js-using-react-redux-8e75871482e9

  if(false){
    return ( <Splash /> );
  }
  return (
    <Router>
      <div className="grid-container">
        <header-container>
          <Header />
        </header-container>
        <navigation-container>
          <Navigation />
        </navigation-container>
        <main-container>
        test
          <Routes> 
              <Route path = "/pages" element = {<Index />} ></Route>
              <Route path = "/pages/info" element = {<Info />}></Route>
              <Route path = "/pages/forgotPassword" element = {<ForgotPassword />}></Route>
              <Route path = "/pages/login" element = {<Login />}></Route>
              <Route path = "/pages/order" element = {<Order />}></Route>
              <Route path = "/pages/register" element = {<Register />}></Route>
          </Routes>
        </main-container>
      </div>
      </Router>
  );
}

export default App;
