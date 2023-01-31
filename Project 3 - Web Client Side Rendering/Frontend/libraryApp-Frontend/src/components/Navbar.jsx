import React, { useContext, useEffect, useState } from 'react'
import PropTypes from 'prop-types'
import "../styles/Navbar.css"
import { Link } from 'react-router-dom';
import { AuthContext } from '../contexts/auth';

const Navbar = props => {
    const [activeTab, setActiveTab] = useState(props.activeTab);
    return (
        <nav className="px-3 py-2 text-bg-dark">
            <div className="container">
                <div className="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                    <Link to="/" className="d-flex align-items-center my-2 my-lg-0 me-lg-auto text-white text-decoration-none">
                        <i className="bi-bank fs-2" />
                    </Link>
                    <ul className="nav col-12 col-lg-auto my-2 justify-content-center my-md-0 text-small">
                        <NavBarItem tabIndex={0} {...{ activeTab, setActiveTab }}>
                            <Link to="/">
                                <i className="bi-house fs-5" />
                                <span>
                                    Home
                                </span>
                            </Link>
                        </NavBarItem>
                        <NavBarItem tabIndex={1} {...{ activeTab, setActiveTab }}>
                            <Link to="/books">
                                <i className="bi-book-half fs-5" />
                                <span>
                                    Books
                                </span>
                            </Link>
                        </NavBarItem>
                        <NavBarItem tabIndex={2} {...{ activeTab, setActiveTab }}>
                            <Link to="/reservations">
                                <i className="bi-archive fs-5" />
                                <span>
                                    Reservations
                                </span>
                            </Link>
                        </NavBarItem>
                        <NavBarItem tabIndex={3} {...{ activeTab, setActiveTab }}>
                            <Link to="/users">
                                <i className="bi-people fs-5" />
                                <span>
                                    Users
                                </span>
                            </Link>
                        </NavBarItem>
                        <AuthButtons />
                    </ul>
                </div>
            </div>
        </nav>
    )
}

const NavBarItem = ({ tabIndex, activeTab, setActiveTab, children, style = {} }) => (
    <li className={`${tabIndex === activeTab ? "active" : ""}`} style={{ ...{ style } }} onClick={() => { setActiveTab(tabIndex) }}>
        {children}
    </li>
);

const AuthButtons = () => {
    const { authState: { username }, logout } = useContext(AuthContext);
    const separatorStyle = {border: "1px #FFFFFF0F solid", borderRadius: "5px", display: "flex" };
    useEffect(() => { console.log("Username:", username) }, []);
    return username ?
        (<li style={separatorStyle} onClick={logout}>
            <Link to="/">
                <i className="bi-box-arrow-right fs-5" />
                <span>
                    Logout
                </span>
            </Link>
        </li>
        ) : (
            <>
                <div style={separatorStyle}>
                    <li>
                        <Link to="/login">
                            <i className="bi-shield-lock fs-5" />
                            <span>
                                Login
                            </span>
                        </Link>
                    </li>
                    <li>
                        <Link to="/signup">
                            <i className="bi-person-plus fs-5" />
                            <span>
                                Signup
                            </span>
                        </Link>
                    </li>
                </div>
            </>
        );
};


Navbar.propTypes = {}

export default Navbar