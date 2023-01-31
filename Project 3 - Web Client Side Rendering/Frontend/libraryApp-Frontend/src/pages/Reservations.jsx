import React from 'react'
import PropTypes from 'prop-types'
import { useProtectedRoute } from '../contexts/auth';

const Reservations = props => {
    useProtectedRoute();
    return (
        <div className="d-flex justify-content-center align-items-center flex-wrap" style={{ minHeight: "90vh" }}>
            <table className="table table-dark table-striped" style={{ width: "50%" }}>
                <thead style={{ height: "2rem" }}>
                    <tr style={{ minWidth: "100%" }}>
                        <th>Reserved Books List</th>
                    </tr>
                </thead>
                <thead style={{ height: "2rem" }}>
                    <tr>
                        <th>#</th>
                        <th>Author</th>
                        <th>Title</th>
                        <th>Publisher</th>
                        <th>Publish Date</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th>2</th>
                        <th>Jeremy Clarkson</th>
                        <th>Can You Make This Thing Go Faster</th>
                        <th>Penguin Random House UK</th>
                        <th>2020</th>
                    </tr>
                    <tr>
                        <th>5</th>
                        <th>Jeremy Clarkson</th>
                        <th>Diddly Squat - a Year on the Farm</th>
                        <th>Penguin Random House UK</th>
                        <th>2020</th>
                    </tr>
                </tbody>
            </table>
        </div>
    )
}

Reservations.propTypes = {}

export default Reservations