import { GetAllProduct } from '@/services/product.service/product.service';
import Link from 'next/link';
import React, { useEffect, useState } from 'react';

const ViewAllProduct = () => {
    const [product,setProduct] = useState();

    useEffect(()=>{
        const getProduct = async () =>{
            const data = await GetAllProduct();
            setProduct(data)
            console.log(data);
        };
            getProduct()
        
    },[]);

    return (
        <>
            <div className='border border-3 p-3 bg-light'>
                <div className='m-5 text-secondary d-flex justify-content-between'>
                    <div>
                        <h2> All Product</h2>
                    </div>
                    <div>
                        <Link href={'/product/create'} className='fs-5'>Add Product</Link>
                    </div>
                </div>
                <div className='p-3 border border-2'>
                    <table className='table table-hover text-center'>
                        <thead>
                            <tr>
                                <th>Product Name</th>
                                <th>Describtion</th>
                                <th>Price</th>
                                <th>Sell Price</th>
                                <th>Country</th>
                                <th>Image</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                product?.map((val)=>(
                                    <tr key={val.id}>
                                        <td>{val.productName}</td>
                                        <td>{val.description}</td>
                                        <td>{val.price}</td>
                                        <td>{val.sellPrice}</td>
                                        <td><img style={{width:"50px", height:"50px"}} src={`https://localhost:7259/${val.imagePath}`} /></td>
                                        <td>
                                            <button className='btn btn-success me-2'>Edit</button>
                                            <button className='btn btn-primary me-2'>View</button>
                                            <button className='btn btn-danger'>Delete</button>
                                        </td>
                                    </tr>
                                ))
                            }
                        </tbody>
                    </table>
                </div>
            </div>
        </>
    );
};

export default ViewAllProduct;