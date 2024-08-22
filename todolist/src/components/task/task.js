import { useId, useState } from 'react';
import { LuPencil } from "react-icons/lu";
import { FaTrash } from "react-icons/fa";
import { ImCheckboxChecked, ImCheckboxUnchecked } from "react-icons/im";
import './task.css'
import { UpdateModal } from '../updateModal/updateModal';

export const Task = ({ array, setArray, item }) => {

    const inputId = useId()

    const [updateModal, setUpdateModal] = useState(false)

    function changeStatus() {
        let index = array.findIndex(task => task.id === item.id)
        array[index] = {
            id: item.id,
            name: item.name,
            status: !item.status
        }
        setArray([
            ...array
        ])
    }

    function deleteTask() {
        let newList = array.filter(task => task.id !== item.id);

        setArray([
            ...newList
        ])
    }

    return (
        <>
            { updateModal ? <UpdateModal item={item} array={array} setArray={setArray} setModal={setUpdateModal} /> : null }
            <div className={item.status ? 'container-task checked' : 'container-task'}>
                <div className='container-task-input' onClick={changeStatus}>
                    {
                        item.status ?
                            <ImCheckboxChecked size={20} />
                            :
                            <ImCheckboxUnchecked size={20} style={{minWidth:'20'}} />
                    }
                    <label htmlFor={inputId}>
                        {item.name}
                    </label>
                </div>
                <div className='container-actions'>
                    <button onClick={deleteTask}>
                        <FaTrash />
                    </button>
                    <button onClick={() => { setUpdateModal(true) }}>
                        <LuPencil />
                    </button>
                </div>
            </div>
        </>
    )
}