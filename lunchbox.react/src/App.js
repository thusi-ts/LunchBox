import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

import Header from "./components/Header";
import Splash from "./components/Splash";
import Navigation from "./components/Navigation";

// pages
import Index from "./components/pages/Index";
import Info from "./components/pages/Info";
import ForgotPassword from "./components/pages/ForgotPassword";
import Login from "./components/pages/Login";
import Register from "./components/pages/Register";


function App() {
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
          <Routes> 
              <Route path = "/pages" exact element = {<Index />}/>
              <Route path = "/pages/info" element = {<Info />}></Route>
              <Route path = "/pages/forgotPassword" element = {<ForgotPassword />}></Route>
              <Route path = "/pages/login" element = {<Login />}></Route>
              <Route path = "/pages/register" element = {<Register />}></Route>
          </Routes>
        </main-container>
      </div>
    </Router>
  );
}


export default App;
