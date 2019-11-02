import React from 'react';
import { TYPE_UNIVERSITY } from '../config/types';

const InputDropdown = ({ items, onItemClick, opened }) => {
  if (!opened) {
    return null;
  }

  return (
    <div className="input-dropdown">
      <ul className="list-none p-0 m-0">
        {items.map((item, index) => (
          <li
            className="search-item"
            key={index}
            onClick={() => onItemClick(item)}
          >
            {item.Title}
            {item.Type !== TYPE_UNIVERSITY && (
              <p className="list-subitem">{item.University}</p>
            )}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default InputDropdown;
