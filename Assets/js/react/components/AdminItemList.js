import React from 'react';

const AdminItemList = ({ items, title, onDelete, onEditSelect, target }) => {
  return (
    <React.Fragment>
      <h2 className="font-light">{title}</h2>
      <div className="list mt-20">
        <table className="table">
          <tbody>
            {items.map(item => (
              <tr key={item.Id}>
                <th scope="row" className="admin-listItem-wider">
                  {item.Title}
                </th>
                <td className="admin-icons-wider">
                  <span
                    onClick={() => onEditSelect(item)}
                    data-target={target}
                    data-toggle="modal"
                  >
                    <i className="fas fa-edit mr-5"></i>
                  </span>
                  <span onClick={() => onDelete(item.Id)}>
                    <i className="fas fa-trash-alt"></i>
                  </span>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </React.Fragment>
  );
};

export default AdminItemList;
