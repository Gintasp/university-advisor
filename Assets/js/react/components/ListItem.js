import React from 'react';
import clsx from 'clsx';
import resolver from '../service/IconClassResolver';

const ListItem = ({ type, children }) => {
  return (
    <p className="list-group-item">
      <i className={clsx(['fas', resolver.resolveIconClass(type), 'mr-5'])}></i>
      {children}
    </p>
  );
};

export default ListItem;
