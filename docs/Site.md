# FilesCom.Models.Site

## Example Site Object

```
{
  "name": "My Site",
  "allowed_2fa_method_sms": true,
  "allowed_2fa_method_totp": true,
  "allowed_2fa_method_u2f": true,
  "allowed_2fa_method_webauthn": true,
  "allowed_2fa_method_yubi": true,
  "allowed_2fa_method_bypass_for_ftp_sftp_dav": true,
  "admin_user_id": 1,
  "allow_bundle_names": true,
  "allowed_countries": "US,DE",
  "allowed_ips": "example",
  "ask_about_overwrites": true,
  "bundle_activity_notifications": "never",
  "bundle_expiration": 1,
  "bundle_password_required": true,
  "bundle_registration_notifications": "never",
  "bundle_require_share_recipient": true,
  "bundle_upload_receipt_notifications": "never",
  "bundle_watermark_attachment": null,
  "bundle_watermark_value": {
    "key": "example value"
  },
  "uploads_via_email_authentication": true,
  "color2_left": "#0066a7",
  "color2_link": "#d34f5d",
  "color2_text": "#0066a7",
  "color2_top": "#000000",
  "color2_top_text": "#ffffff",
  "contact_name": "John Doe",
  "created_at": "2000-01-01T01:00:00Z",
  "currency": "USD",
  "custom_namespace": true,
  "days_to_retain_backups": 30,
  "default_time_zone": "Pacific Time (US & Canada)",
  "desktop_app": true,
  "desktop_app_session_ip_pinning": true,
  "desktop_app_session_lifetime": 1,
  "mobile_app": true,
  "mobile_app_session_ip_pinning": true,
  "mobile_app_session_lifetime": 1,
  "disallowed_countries": "US,DE",
  "disable_files_certificate_generation": true,
  "disable_notifications": true,
  "disable_password_reset": true,
  "domain": "my-custom-domain.com",
  "domain_hsts_header": true,
  "domain_letsencrypt_chain": "example",
  "email": "example",
  "ftp_enabled": true,
  "reply_to_email": "example",
  "non_sso_groups_allowed": true,
  "non_sso_users_allowed": true,
  "folder_permissions_groups_only": true,
  "hipaa": true,
  "icon128": null,
  "icon16": null,
  "icon32": null,
  "icon48": null,
  "immutable_files_set_at": "2000-01-01T01:00:00Z",
  "include_password_in_welcome_email": true,
  "language": "en",
  "ldap_base_dn": "example",
  "ldap_domain": "mysite.com",
  "ldap_enabled": true,
  "ldap_group_action": "disabled",
  "ldap_group_exclusion": "example",
  "ldap_group_inclusion": "example",
  "ldap_host": "ldap.site.com",
  "ldap_host_2": "ldap2.site.com",
  "ldap_host_3": "ldap3.site.com",
  "ldap_port": 1,
  "ldap_secure": true,
  "ldap_type": "open_ldap",
  "ldap_user_action": "disabled",
  "ldap_user_include_groups": "example",
  "ldap_username": "[ldap username]",
  "ldap_username_field": "sAMAccountName",
  "login_help_text": "Login page help text.",
  "logo": null,
  "max_prior_passwords": 1,
  "motd_text": "example",
  "motd_use_for_ftp": true,
  "motd_use_for_sftp": true,
  "next_billing_amount": 1.0,
  "next_billing_date": "Apr 20",
  "office_integration_available": true,
  "office_integration_type": "example",
  "oncehub_link": "https://go.oncehub.com/files",
  "opt_out_global": true,
  "overdue": true,
  "password_min_length": 1,
  "password_require_letter": true,
  "password_require_mixed": true,
  "password_require_number": true,
  "password_require_special": true,
  "password_require_unbreached": true,
  "password_requirements_apply_to_bundles": true,
  "password_validity_days": 1,
  "phone": "555-555-5555",
  "pin_all_remote_servers_to_site_region": true,
  "require_2fa": true,
  "require_2fa_stop_time": "2000-01-01T01:00:00Z",
  "require_2fa_user_type": "`site_admins`",
  "session": {
    "id": "60525f92e859c4c3d74cb02fd176b1525901b525",
    "language": "en",
    "read_only": true,
    "sftp_insecure_ciphers": true
  },
  "session_pinned_by_ip": true,
  "sftp_enabled": true,
  "sftp_host_key_type": "default",
  "active_sftp_host_key_id": 1,
  "sftp_insecure_ciphers": true,
  "sftp_user_root_enabled": true,
  "sharing_enabled": true,
  "show_request_access_link": true,
  "site_footer": "example",
  "site_header": "example",
  "smtp_address": "smtp.my-mail-server.com",
  "smtp_authentication": "plain",
  "smtp_from": "me@my-mail-server.com",
  "smtp_port": 25,
  "smtp_username": "mail",
  "session_expiry": 6.0,
  "session_expiry_minutes": 360,
  "ssl_required": true,
  "subdomain": "mysite",
  "switch_to_plan_date": "2000-01-01T01:00:00Z",
  "tls_disabled": true,
  "trial_days_left": 1,
  "trial_until": "2000-01-01T01:00:00Z",
  "updated_at": "2000-01-01T01:00:00Z",
  "use_provided_modified_at": true,
  "user": {
    "id": 1,
    "username": "user",
    "admin_group_ids": [
      1
    ],
    "allowed_ips": "127.0.0.1",
    "attachments_permission": true,
    "api_keys_count": 1,
    "authenticate_until": "2000-01-01T01:00:00Z",
    "authentication_method": "password",
    "avatar_url": "example",
    "billing_permission": true,
    "bypass_site_allowed_ips": true,
    "bypass_inactive_disable": true,
    "created_at": "2000-01-01T01:00:00Z",
    "dav_permission": true,
    "disabled": true,
    "email": "example",
    "first_login_at": "2000-01-01T01:00:00Z",
    "ftp_permission": true,
    "group_ids": "example",
    "header_text": "User-specific message.",
    "language": "en",
    "last_login_at": "2000-01-01T01:00:00Z",
    "last_web_login_at": "2000-01-01T01:00:00Z",
    "last_ftp_login_at": "2000-01-01T01:00:00Z",
    "last_sftp_login_at": "2000-01-01T01:00:00Z",
    "last_dav_login_at": "2000-01-01T01:00:00Z",
    "last_desktop_login_at": "2000-01-01T01:00:00Z",
    "last_restapi_login_at": "2000-01-01T01:00:00Z",
    "last_api_use_at": "2000-01-01T01:00:00Z",
    "last_active_at": "2000-01-01T01:00:00Z",
    "last_protocol_cipher": "example",
    "lockout_expires": "2000-01-01T01:00:00Z",
    "name": "John Doe",
    "company": "ACME Corp.",
    "notes": "Internal notes on this user.",
    "notification_daily_send_time": 18,
    "office_integration_enabled": true,
    "password_set_at": "2000-01-01T01:00:00Z",
    "password_validity_days": 1,
    "public_keys_count": 1,
    "receive_admin_alerts": true,
    "require_2fa": "always_require",
    "active_2fa": true,
    "require_password_change": true,
    "password_expired": true,
    "restapi_permission": true,
    "self_managed": true,
    "sftp_permission": true,
    "site_admin": true,
    "skip_welcome_screen": true,
    "ssl_required": "always_require",
    "sso_strategy_id": 1,
    "subscribe_to_newsletter": true,
    "externally_managed": true,
    "time_zone": "Pacific Time (US & Canada)",
    "type_of_2fa": "yubi",
    "user_root": "example",
    "days_remaining_until_password_expire": 1,
    "password_expire_at": "2000-01-01T01:00:00Z"
  },
  "user_lockout": true,
  "user_lockout_lock_period": 1,
  "user_lockout_tries": 1,
  "user_lockout_within": 6,
  "user_requests_enabled": true,
  "user_requests_notify_admins": true,
  "welcome_custom_text": "Welcome to my site!",
  "welcome_email_cc": "example",
  "welcome_email_subject": "example",
  "welcome_email_enabled": true,
  "welcome_screen": "user_controlled",
  "windows_mode_ftp": true,
  "disable_users_from_inactivity_period_days": 1,
  "group_admins_can_set_user_password": true
}
```

* `name` / `Name`  (string): Site name
* `allowed_2fa_method_sms` / `Allowed2faMethodSms`  (bool): Is SMS two factor authentication allowed?
* `allowed_2fa_method_totp` / `Allowed2faMethodTotp`  (bool): Is TOTP two factor authentication allowed?
* `allowed_2fa_method_u2f` / `Allowed2faMethodU2f`  (bool): Is U2F two factor authentication allowed?
* `allowed_2fa_method_webauthn` / `Allowed2faMethodWebauthn`  (bool): Is WebAuthn two factor authentication allowed?
* `allowed_2fa_method_yubi` / `Allowed2faMethodYubi`  (bool): Is yubikey two factor authentication allowed?
* `allowed_2fa_method_bypass_for_ftp_sftp_dav` / `Allowed2faMethodBypassForFtpSftpDav`  (bool): Are users allowed to configure their two factor authentication to be bypassed for FTP/SFTP/WebDAV?
* `admin_user_id` / `AdminUserId`  (Nullable<Int64>): User ID for the main site administrator
* `allow_bundle_names` / `AllowBundleNames`  (bool): Are manual Bundle names allowed?
* `allowed_countries` / `AllowedCountries`  (string): Comma seperated list of allowed Country codes
* `allowed_ips` / `AllowedIps`  (string): List of allowed IP addresses
* `ask_about_overwrites` / `AskAboutOverwrites`  (bool): If false, rename conflicting files instead of asking for overwrite confirmation.  Only applies to web interface.
* `bundle_activity_notifications` / `BundleActivityNotifications`  (string): Do Bundle owners receive activity notifications?
* `bundle_expiration` / `BundleExpiration`  (Nullable<Int64>): Site-wide Bundle expiration in days
* `bundle_password_required` / `BundlePasswordRequired`  (bool): Do Bundles require password protection?
* `bundle_registration_notifications` / `BundleRegistrationNotifications`  (string): Do Bundle owners receive registration notification?
* `bundle_require_share_recipient` / `BundleRequireShareRecipient`  (bool): Do Bundles require recipients for sharing?
* `bundle_upload_receipt_notifications` / `BundleUploadReceiptNotifications`  (string): Do Bundle uploaders receive upload confirmation notifications?
* `bundle_watermark_attachment` / `BundleWatermarkAttachment`  (Image): Preview watermark image applied to all bundle items.
* `bundle_watermark_value` / `BundleWatermarkValue`  (object): Preview watermark settings applied to all bundle items. Uses the same keys as Behavior.value
* `uploads_via_email_authentication` / `UploadsViaEmailAuthentication`  (bool): Do incoming emails in the Inboxes require checking for SPF/DKIM/DMARC?
* `color2_left` / `Color2Left`  (string): Page link and button color
* `color2_link` / `Color2Link`  (string): Top bar link color
* `color2_text` / `Color2Text`  (string): Page link and button color
* `color2_top` / `Color2Top`  (string): Top bar background color
* `color2_top_text` / `Color2TopText`  (string): Top bar text color
* `contact_name` / `ContactName`  (string): Site main contact name
* `created_at` / `CreatedAt`  (Nullable<DateTime>): Time this site was created
* `currency` / `Currency`  (string): Preferred currency
* `custom_namespace` / `CustomNamespace`  (bool): Is this site using a custom namespace for users?
* `days_to_retain_backups` / `DaysToRetainBackups`  (Nullable<Int64>): Number of days to keep deleted files
* `default_time_zone` / `DefaultTimeZone`  (string): Site default time zone
* `desktop_app` / `DesktopApp`  (bool): Is the desktop app enabled?
* `desktop_app_session_ip_pinning` / `DesktopAppSessionIpPinning`  (bool): Is desktop app session IP pinning enabled?
* `desktop_app_session_lifetime` / `DesktopAppSessionLifetime`  (Nullable<Int64>): Desktop app session lifetime (in hours)
* `mobile_app` / `MobileApp`  (bool): Is the mobile app enabled?
* `mobile_app_session_ip_pinning` / `MobileAppSessionIpPinning`  (bool): Is mobile app session IP pinning enabled?
* `mobile_app_session_lifetime` / `MobileAppSessionLifetime`  (Nullable<Int64>): Mobile app session lifetime (in hours)
* `disallowed_countries` / `DisallowedCountries`  (string): Comma seperated list of disallowed Country codes
* `disable_files_certificate_generation` / `DisableFilesCertificateGeneration`  (bool): If set, Files.com will not set the CAA records required to generate future SSL certificates for this domain.
* `disable_notifications` / `DisableNotifications`  (bool): Are notifications disabled?
* `disable_password_reset` / `DisablePasswordReset`  (bool): Is password reset disabled?
* `domain` / `Domain`  (string): Custom domain
* `domain_hsts_header` / `DomainHstsHeader`  (bool): Send HSTS (HTTP Strict Transport Security) header when visitors access the site via a custom domain?
* `domain_letsencrypt_chain` / `DomainLetsencryptChain`  (string): Letsencrypt chain to use when registering SSL Certificate for domain.
* `email` / `Email`  (string): Main email for this site
* `ftp_enabled` / `FtpEnabled`  (bool): Is FTP enabled?
* `reply_to_email` / `ReplyToEmail`  (string): Reply-to email for this site
* `non_sso_groups_allowed` / `NonSsoGroupsAllowed`  (bool): If true, groups can be manually created / modified / deleted by Site Admins. Otherwise, groups can only be managed via your SSO provider.
* `non_sso_users_allowed` / `NonSsoUsersAllowed`  (bool): If true, users can be manually created / modified / deleted by Site Admins. Otherwise, users can only be managed via your SSO provider.
* `folder_permissions_groups_only` / `FolderPermissionsGroupsOnly`  (bool): If true, permissions for this site must be bound to a group (not a user). Otherwise, permissions must be bound to a user.
* `hipaa` / `Hipaa`  (bool): Is there a signed HIPAA BAA between Files.com and this site?
* `icon128` / `Icon128`  (Image): Branded icon 128x128
* `icon16` / `Icon16`  (Image): Branded icon 16x16
* `icon32` / `Icon32`  (Image): Branded icon 32x32
* `icon48` / `Icon48`  (Image): Branded icon 48x48
* `immutable_files_set_at` / `ImmutableFilesSetAt`  (Nullable<DateTime>): Can files be modified?
* `include_password_in_welcome_email` / `IncludePasswordInWelcomeEmail`  (bool): Include password in emails to new users?
* `language` / `Language`  (string): Site default language
* `ldap_base_dn` / `LdapBaseDn`  (string): Base DN for looking up users in LDAP server
* `ldap_domain` / `LdapDomain`  (string): Domain name that will be appended to usernames
* `ldap_enabled` / `LdapEnabled`  (bool): Main LDAP setting: is LDAP enabled?
* `ldap_group_action` / `LdapGroupAction`  (string): Should we sync groups from LDAP server?
* `ldap_group_exclusion` / `LdapGroupExclusion`  (string): Comma or newline separated list of group names (with optional wildcards) to exclude when syncing.
* `ldap_group_inclusion` / `LdapGroupInclusion`  (string): Comma or newline separated list of group names (with optional wildcards) to include when syncing.
* `ldap_host` / `LdapHost`  (string): LDAP host
* `ldap_host_2` / `LdapHost2`  (string): LDAP backup host
* `ldap_host_3` / `LdapHost3`  (string): LDAP backup host
* `ldap_port` / `LdapPort`  (Nullable<Int64>): LDAP port
* `ldap_secure` / `LdapSecure`  (bool): Use secure LDAP?
* `ldap_type` / `LdapType`  (string): LDAP type
* `ldap_user_action` / `LdapUserAction`  (string): Should we sync users from LDAP server?
* `ldap_user_include_groups` / `LdapUserIncludeGroups`  (string): Comma or newline separated list of group names (with optional wildcards) - if provided, only users in these groups will be added or synced.
* `ldap_username` / `LdapUsername`  (string): Username for signing in to LDAP server.
* `ldap_username_field` / `LdapUsernameField`  (string): LDAP username field
* `login_help_text` / `LoginHelpText`  (string): Login help text
* `logo` / `Logo`  (Image): Branded logo
* `max_prior_passwords` / `MaxPriorPasswords`  (Nullable<Int64>): Number of prior passwords to disallow
* `motd_text` / `MotdText`  (string): A message to show users when they connect via FTP or SFTP.
* `motd_use_for_ftp` / `MotdUseForFtp`  (bool): Show message to users connecting via FTP
* `motd_use_for_sftp` / `MotdUseForSftp`  (bool): Show message to users connecting via SFTP
* `next_billing_amount` / `NextBillingAmount`  (double): Next billing amount
* `next_billing_date` / `NextBillingDate`  (string): Next billing date
* `office_integration_available` / `OfficeIntegrationAvailable`  (bool): Allow users to use Office for the web?
* `office_integration_type` / `OfficeIntegrationType`  (string): Office integration application used to edit and view the MS Office documents
* `oncehub_link` / `OncehubLink`  (string): Link to scheduling a meeting with our Sales team
* `opt_out_global` / `OptOutGlobal`  (bool): Use servers in the USA only?
* `overdue` / `Overdue`  (bool): Is this site's billing overdue?
* `password_min_length` / `PasswordMinLength`  (Nullable<Int64>): Shortest password length for users
* `password_require_letter` / `PasswordRequireLetter`  (bool): Require a letter in passwords?
* `password_require_mixed` / `PasswordRequireMixed`  (bool): Require lower and upper case letters in passwords?
* `password_require_number` / `PasswordRequireNumber`  (bool): Require a number in passwords?
* `password_require_special` / `PasswordRequireSpecial`  (bool): Require special characters in password?
* `password_require_unbreached` / `PasswordRequireUnbreached`  (bool): Require passwords that have not been previously breached? (see https://haveibeenpwned.com/)
* `password_requirements_apply_to_bundles` / `PasswordRequirementsApplyToBundles`  (bool): Require bundles' passwords, and passwords for other items (inboxes, public shares, etc.) to conform to the same requirements as users' passwords?
* `password_validity_days` / `PasswordValidityDays`  (Nullable<Int64>): Number of days password is valid
* `phone` / `Phone`  (string): Site phone number
* `pin_all_remote_servers_to_site_region` / `PinAllRemoteServersToSiteRegion`  (bool): If true, we will ensure that all internal communications with any remote server are made through the primary region of the site. This setting overrides individual remote server settings.
* `require_2fa` / `Require2fa`  (bool): Require two-factor authentication for all users?
* `require_2fa_stop_time` / `Require2faStopTime`  (Nullable<DateTime>): If set, requirement for two-factor authentication has been scheduled to end on this date-time.
* `require_2fa_user_type` / `Require2faUserType`  (string): What type of user is required to use two-factor authentication (when require_2fa is set to `true` for this site)?
* `session` / `Session`  (Session): Current session
* `session_pinned_by_ip` / `SessionPinnedByIp`  (bool): Are sessions locked to the same IP? (i.e. do users need to log in again if they change IPs?)
* `sftp_enabled` / `SftpEnabled`  (bool): Is SFTP enabled?
* `sftp_host_key_type` / `SftpHostKeyType`  (string): Sftp Host Key Type
* `active_sftp_host_key_id` / `ActiveSftpHostKeyId`  (Nullable<Int64>): Id of the currently selected custom SFTP Host Key
* `sftp_insecure_ciphers` / `SftpInsecureCiphers`  (bool): Are Insecure Ciphers allowed for SFTP?  Note:  Settting TLS Disabled -> True will always allow insecure ciphers for SFTP as well.  Enabling this is insecure.
* `sftp_user_root_enabled` / `SftpUserRootEnabled`  (bool): Use user FTP roots also for SFTP?
* `sharing_enabled` / `SharingEnabled`  (bool): Allow bundle creation
* `show_request_access_link` / `ShowRequestAccessLink`  (bool): Show request access link for users without access?  Currently unused.
* `site_footer` / `SiteFooter`  (string): Custom site footer text
* `site_header` / `SiteHeader`  (string): Custom site header text
* `smtp_address` / `SmtpAddress`  (string): SMTP server hostname or IP
* `smtp_authentication` / `SmtpAuthentication`  (string): SMTP server authentication type
* `smtp_from` / `SmtpFrom`  (string): From address to use when mailing through custom SMTP
* `smtp_port` / `SmtpPort`  (Nullable<Int64>): SMTP server port
* `smtp_username` / `SmtpUsername`  (string): SMTP server username
* `session_expiry` / `SessionExpiry`  (double): Session expiry in hours
* `session_expiry_minutes` / `SessionExpiryMinutes`  (Nullable<Int64>): Session expiry in minutes
* `ssl_required` / `SslRequired`  (bool): Is SSL required?  Disabling this is insecure.
* `subdomain` / `Subdomain`  (string): Site subdomain
* `switch_to_plan_date` / `SwitchToPlanDate`  (Nullable<DateTime>): If switching plans, when does the new plan take effect?
* `tls_disabled` / `TlsDisabled`  (bool): Are Insecure TLS and SFTP Ciphers allowed?  Enabling this is insecure.
* `trial_days_left` / `TrialDaysLeft`  (Nullable<Int64>): Number of days left in trial
* `trial_until` / `TrialUntil`  (Nullable<DateTime>): When does this Site trial expire?
* `updated_at` / `UpdatedAt`  (Nullable<DateTime>): Last time this Site was updated
* `use_provided_modified_at` / `UseProvidedModifiedAt`  (bool): Allow uploaders to set `provided_modified_at` for uploaded files?
* `user` / `User`  (User): User of current session
* `user_lockout` / `UserLockout`  (bool): Will users be locked out after incorrect login attempts?
* `user_lockout_lock_period` / `UserLockoutLockPeriod`  (Nullable<Int64>): How many hours to lock user out for failed password?
* `user_lockout_tries` / `UserLockoutTries`  (Nullable<Int64>): Number of login tries within `user_lockout_within` hours before users are locked out
* `user_lockout_within` / `UserLockoutWithin`  (Nullable<Int64>): Number of hours for user lockout window
* `user_requests_enabled` / `UserRequestsEnabled`  (bool): Enable User Requests feature
* `user_requests_notify_admins` / `UserRequestsNotifyAdmins`  (bool): Send email to site admins when a user request is received?
* `welcome_custom_text` / `WelcomeCustomText`  (string): Custom text send in user welcome email
* `welcome_email_cc` / `WelcomeEmailCc`  (string): Include this email in welcome emails if enabled
* `welcome_email_subject` / `WelcomeEmailSubject`  (string): Include this email subject in welcome emails if enabled
* `welcome_email_enabled` / `WelcomeEmailEnabled`  (bool): Will the welcome email be sent to new users?
* `welcome_screen` / `WelcomeScreen`  (string): Does the welcome screen appear?
* `windows_mode_ftp` / `WindowsModeFtp`  (bool): Does FTP user Windows emulation mode?
* `disable_users_from_inactivity_period_days` / `DisableUsersFromInactivityPeriodDays`  (Nullable<Int64>): If greater than zero, users will unable to login if they do not show activity within this number of days.
* `group_admins_can_set_user_password` / `GroupAdminsCanSetUserPassword`  (bool): Allow group admins set password authentication method


---

## Show site settings

```
Task<Site> Site.Get(
    
    Dictionary<string, object> parameters = null,
    Dictionary<string, object> options = null
)
```


---

## Get the most recent usage snapshot (usage data for billing purposes) for a Site

```
Task<UsageSnapshot> Site.GetUsage(
    
    Dictionary<string, object> parameters = null,
    Dictionary<string, object> options = null
)
```


---

## Update site settings

```
Task<Site> Site.Update(
    
    Dictionary<string, object> parameters = null,
    Dictionary<string, object> options = null
)
```

### Parameters

* `name` (string): Site name
* `subdomain` (string): Site subdomain
* `domain` (string): Custom domain
* `domain_hsts_header` (bool): Send HSTS (HTTP Strict Transport Security) header when visitors access the site via a custom domain?
* `domain_letsencrypt_chain` (string): Letsencrypt chain to use when registering SSL Certificate for domain.
* `email` (string): Main email for this site
* `reply_to_email` (string): Reply-to email for this site
* `allow_bundle_names` (bool): Are manual Bundle names allowed?
* `bundle_expiration` (Nullable<Int64>): Site-wide Bundle expiration in days
* `welcome_email_enabled` (bool): Will the welcome email be sent to new users?
* `ask_about_overwrites` (bool): If false, rename conflicting files instead of asking for overwrite confirmation.  Only applies to web interface.
* `show_request_access_link` (bool): Show request access link for users without access?  Currently unused.
* `welcome_email_cc` (string): Include this email in welcome emails if enabled
* `welcome_email_subject` (string): Include this email subject in welcome emails if enabled
* `welcome_custom_text` (string): Custom text send in user welcome email
* `language` (string): Site default language
* `windows_mode_ftp` (bool): Does FTP user Windows emulation mode?
* `default_time_zone` (string): Site default time zone
* `desktop_app` (bool): Is the desktop app enabled?
* `desktop_app_session_ip_pinning` (bool): Is desktop app session IP pinning enabled?
* `desktop_app_session_lifetime` (Nullable<Int64>): Desktop app session lifetime (in hours)
* `mobile_app` (bool): Is the mobile app enabled?
* `mobile_app_session_ip_pinning` (bool): Is mobile app session IP pinning enabled?
* `mobile_app_session_lifetime` (Nullable<Int64>): Mobile app session lifetime (in hours)
* `folder_permissions_groups_only` (bool): If true, permissions for this site must be bound to a group (not a user). Otherwise, permissions must be bound to a user.
* `welcome_screen` (string): Does the welcome screen appear?
* `office_integration_available` (bool): Allow users to use Office for the web?
* `office_integration_type` (string): Office integration application used to edit and view the MS Office documents
* `pin_all_remote_servers_to_site_region` (bool): If true, we will ensure that all internal communications with any remote server are made through the primary region of the site. This setting overrides individual remote server settings.
* `motd_text` (string): A message to show users when they connect via FTP or SFTP.
* `motd_use_for_ftp` (bool): Show message to users connecting via FTP
* `motd_use_for_sftp` (bool): Show message to users connecting via SFTP
* `session_expiry` (double): Session expiry in hours
* `ssl_required` (bool): Is SSL required?  Disabling this is insecure.
* `tls_disabled` (bool): Are Insecure TLS and SFTP Ciphers allowed?  Enabling this is insecure.
* `sftp_insecure_ciphers` (bool): Are Insecure Ciphers allowed for SFTP?  Note:  Settting TLS Disabled -> True will always allow insecure ciphers for SFTP as well.  Enabling this is insecure.
* `disable_files_certificate_generation` (bool): If set, Files.com will not set the CAA records required to generate future SSL certificates for this domain.
* `user_lockout` (bool): Will users be locked out after incorrect login attempts?
* `user_lockout_tries` (Nullable<Int64>): Number of login tries within `user_lockout_within` hours before users are locked out
* `user_lockout_within` (Nullable<Int64>): Number of hours for user lockout window
* `user_lockout_lock_period` (Nullable<Int64>): How many hours to lock user out for failed password?
* `include_password_in_welcome_email` (bool): Include password in emails to new users?
* `allowed_countries` (string): Comma seperated list of allowed Country codes
* `allowed_ips` (string): List of allowed IP addresses
* `disallowed_countries` (string): Comma seperated list of disallowed Country codes
* `days_to_retain_backups` (Nullable<Int64>): Number of days to keep deleted files
* `max_prior_passwords` (Nullable<Int64>): Number of prior passwords to disallow
* `password_validity_days` (Nullable<Int64>): Number of days password is valid
* `password_min_length` (Nullable<Int64>): Shortest password length for users
* `password_require_letter` (bool): Require a letter in passwords?
* `password_require_mixed` (bool): Require lower and upper case letters in passwords?
* `password_require_special` (bool): Require special characters in password?
* `password_require_number` (bool): Require a number in passwords?
* `password_require_unbreached` (bool): Require passwords that have not been previously breached? (see https://haveibeenpwned.com/)
* `sftp_user_root_enabled` (bool): Use user FTP roots also for SFTP?
* `disable_password_reset` (bool): Is password reset disabled?
* `immutable_files` (bool): Are files protected from modification?
* `session_pinned_by_ip` (bool): Are sessions locked to the same IP? (i.e. do users need to log in again if they change IPs?)
* `bundle_password_required` (bool): Do Bundles require password protection?
* `bundle_require_share_recipient` (bool): Do Bundles require recipients for sharing?
* `bundle_registration_notifications` (string): Do Bundle owners receive registration notification?
* `bundle_activity_notifications` (string): Do Bundle owners receive activity notifications?
* `bundle_upload_receipt_notifications` (string): Do Bundle uploaders receive upload confirmation notifications?
* `password_requirements_apply_to_bundles` (bool): Require bundles' passwords, and passwords for other items (inboxes, public shares, etc.) to conform to the same requirements as users' passwords?
* `opt_out_global` (bool): Use servers in the USA only?
* `use_provided_modified_at` (bool): Allow uploaders to set `provided_modified_at` for uploaded files?
* `custom_namespace` (bool): Is this site using a custom namespace for users?
* `disable_users_from_inactivity_period_days` (Nullable<Int64>): If greater than zero, users will unable to login if they do not show activity within this number of days.
* `non_sso_groups_allowed` (bool): If true, groups can be manually created / modified / deleted by Site Admins. Otherwise, groups can only be managed via your SSO provider.
* `non_sso_users_allowed` (bool): If true, users can be manually created / modified / deleted by Site Admins. Otherwise, users can only be managed via your SSO provider.
* `sharing_enabled` (bool): Allow bundle creation
* `user_requests_enabled` (bool): Enable User Requests feature
* `user_requests_notify_admins` (bool): Send email to site admins when a user request is received?
* `ftp_enabled` (bool): Is FTP enabled?
* `sftp_enabled` (bool): Is SFTP enabled?
* `sftp_host_key_type` (string): Sftp Host Key Type
* `active_sftp_host_key_id` (Nullable<Int64>): Id of the currently selected custom SFTP Host Key
* `bundle_watermark_value` (object): Preview watermark settings applied to all bundle items. Uses the same keys as Behavior.value
* `group_admins_can_set_user_password` (bool): Allow group admins set password authentication method
* `allowed_2fa_method_sms` (bool): Is SMS two factor authentication allowed?
* `allowed_2fa_method_u2f` (bool): Is U2F two factor authentication allowed?
* `allowed_2fa_method_totp` (bool): Is TOTP two factor authentication allowed?
* `allowed_2fa_method_webauthn` (bool): Is WebAuthn two factor authentication allowed?
* `allowed_2fa_method_yubi` (bool): Is yubikey two factor authentication allowed?
* `allowed_2fa_method_bypass_for_ftp_sftp_dav` (bool): Are users allowed to configure their two factor authentication to be bypassed for FTP/SFTP/WebDAV?
* `require_2fa` (bool): Require two-factor authentication for all users?
* `require_2fa_user_type` (string): What type of user is required to use two-factor authentication (when require_2fa is set to `true` for this site)?
* `color2_top` (string): Top bar background color
* `color2_left` (string): Page link and button color
* `color2_link` (string): Top bar link color
* `color2_text` (string): Page link and button color
* `color2_top_text` (string): Top bar text color
* `site_header` (string): Custom site header text
* `site_footer` (string): Custom site footer text
* `login_help_text` (string): Login help text
* `smtp_address` (string): SMTP server hostname or IP
* `smtp_authentication` (string): SMTP server authentication type
* `smtp_from` (string): From address to use when mailing through custom SMTP
* `smtp_username` (string): SMTP server username
* `smtp_port` (Nullable<Int64>): SMTP server port
* `ldap_enabled` (bool): Main LDAP setting: is LDAP enabled?
* `ldap_type` (string): LDAP type
* `ldap_host` (string): LDAP host
* `ldap_host_2` (string): LDAP backup host
* `ldap_host_3` (string): LDAP backup host
* `ldap_port` (Nullable<Int64>): LDAP port
* `ldap_secure` (bool): Use secure LDAP?
* `ldap_username` (string): Username for signing in to LDAP server.
* `ldap_username_field` (string): LDAP username field
* `ldap_domain` (string): Domain name that will be appended to usernames
* `ldap_user_action` (string): Should we sync users from LDAP server?
* `ldap_group_action` (string): Should we sync groups from LDAP server?
* `ldap_user_include_groups` (string): Comma or newline separated list of group names (with optional wildcards) - if provided, only users in these groups will be added or synced.
* `ldap_group_exclusion` (string): Comma or newline separated list of group names (with optional wildcards) to exclude when syncing.
* `ldap_group_inclusion` (string): Comma or newline separated list of group names (with optional wildcards) to include when syncing.
* `ldap_base_dn` (string): Base DN for looking up users in LDAP server
* `uploads_via_email_authentication` (bool): Do incoming emails in the Inboxes require checking for SPF/DKIM/DMARC?
* `icon16_file` (System.Net.Http.ByteArrayContent): 
* `icon16_delete` (bool): If true, will delete the file stored in icon16
* `icon32_file` (System.Net.Http.ByteArrayContent): 
* `icon32_delete` (bool): If true, will delete the file stored in icon32
* `icon48_file` (System.Net.Http.ByteArrayContent): 
* `icon48_delete` (bool): If true, will delete the file stored in icon48
* `icon128_file` (System.Net.Http.ByteArrayContent): 
* `icon128_delete` (bool): If true, will delete the file stored in icon128
* `logo_file` (System.Net.Http.ByteArrayContent): 
* `logo_delete` (bool): If true, will delete the file stored in logo
* `bundle_watermark_attachment_file` (System.Net.Http.ByteArrayContent): 
* `bundle_watermark_attachment_delete` (bool): If true, will delete the file stored in bundle_watermark_attachment
* `disable_2fa_with_delay` (bool): If set to true, we will begin the process of disabling 2FA on this site.
* `ldap_password_change` (string): New LDAP password.
* `ldap_password_change_confirmation` (string): Confirm new LDAP password.
* `smtp_password` (string): Password for SMTP server.
* `session_expiry_minutes` (Nullable<Int64>): Session expiry in minutes
