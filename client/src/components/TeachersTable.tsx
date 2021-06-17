import * as React from 'react';
import { DataGrid, GridColDef, GridValueGetterParams } from '@material-ui/data-grid';

const columns: GridColDef[] = [
  { field: 'id', headerName: 'KeyID', width: 150 },
  { field: 'roomNumber', headerName: 'Room Number', width: 150 },

  {
    field: 'qrCode',
    headerName: 'QR Code',
    description: 'This column get string qrCode using Keyid + number.',
    sortable: false,
    width: 160,
    valueGetter: (params: GridValueGetterParams) =>
      `${params.getValue(params.id, 'id') || ''}${
        params.getValue(params.id, 'roomNumber') || ''
      }`,
  },
 
];

const rows = [
  { id: 1, roomNumber: 'A100' },
  { id: 2, roomNumber: 'A102' },
  { id: 3, roomNumber: 'A103' },
  { id: 4, roomNumber: 'A201' },
  { id: 5, roomNumber: 'A310' },
  { id: 6, roomNumber: 'A202' },
  { id: 7, roomNumber: 'A107' },
];

export default function DataGridDemo() {
  return (
    <div style={{ height: 400, width: '100%' }}>
      <DataGrid rows={rows} columns={columns} pageSize={5} checkboxSelection />
    </div>
  );
}