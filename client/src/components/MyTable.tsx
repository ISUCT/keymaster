import  React, { Component } from "react";
import { DataGrid, GridColDef, GridValueGetterParams } from '@material-ui/data-grid';

const columns: GridColDef[] = [
    { field: 'id', headerName: 'ID', width: 90 },
    { field: 'fullName', headerName: 'FullName', width: 150 },
    { field: 'personalKey', headerName: 'Personal key', width: 150 },
  ];

  const rows = [
    { id: 1, fullName: 'qwe qwe qew', personalKey: 'diufsufydsgf' },
    { id: 2, fullName: 'asda adsa adaa', personalKey: 'ewqheiuw31231231n' },
    { id: 3, fullName: 'asd asd awq', personalKey: 'qweqwew123qweq312' },
    { id: 4, fullName: 'vf vfv fffff', personalKey: 'qweqweqweqewqe' },
    { id: 5, fullName: 'qwee weqw ', personalKey: 'qweqeqeqeq1' },
    { id: 6, fullName: 'Sdf  wewqe qweq', personalKey: 'asdas312dsf' },
    { id: 7, fullName: 'Snow qw ewe', personalKey: 'sdrfjuwh21' },
  ];

export default function DataGridDemo() {
  return (
    <div style={{ height: 400, width: '100%' }}>
      <DataGrid rows={rows} columns={columns} pageSize={5} checkboxSelection />
    </div>
  );
}
