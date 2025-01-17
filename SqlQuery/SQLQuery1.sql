INSERT INTO [dbo].[Users] ([Username], [Password], [Email], [Role], [UpdatedAt], [IsActive])
VALUES
    ('admin_user', 'Admin123!', 'admin@example.com', 'Admin', GETDATE(), 1),
    ('manager_user', 'Manager123!', 'manager@example.com', 'Manager', GETDATE(), 1),
    ('employee1', 'Employee123!', 'employee1@example.com', 'Employee', GETDATE(), 1),
    ('employee2', 'Employee123!', 'employee2@example.com', 'Employee', GETDATE(), 1),
    ('inactive_user', 'Inactive123!', 'inactive@example.com', 'Employee', GETDATE(), 0);
