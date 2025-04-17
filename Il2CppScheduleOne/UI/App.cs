using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000650 RID: 1616
	public class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
	{
		// Token: 0x06008FE4 RID: 36836 RVA: 0x00254A8C File Offset: 0x00252C8C
		// Note: this type is marked as 'beforefieldinit'.
		static App()
		{
			Il2CppClassPointerStore<App<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "App`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<App<T>>.NativeClassPtr);
			App<T>.NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Apps");
			App<T>.NativeFieldInfoPtr_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppName");
			App<T>.NativeFieldInfoPtr_IconLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "IconLabel");
			App<T>.NativeFieldInfoPtr_AppIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AppIcon");
			App<T>.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "Orientation");
			App<T>.NativeFieldInfoPtr_AvailableInTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "AvailableInTutorial");
			App<T>.NativeFieldInfoPtr_appContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appContainer");
			App<T>.NativeFieldInfoPtr_notificationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationContainer");
			App<T>.NativeFieldInfoPtr_notificationText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "notificationText");
			App<T>.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "<isOpen>k__BackingField");
			App<T>.NativeFieldInfoPtr_appIconButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<App<T>>.NativeClassPtr, "appIconButton");
			App<T>.NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681124);
			App<T>.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681125);
			App<T>.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681126);
			App<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681127);
			App<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681128);
			App<T>.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681129);
			App<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681130);
			App<T>.NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681131);
			App<T>.NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681132);
			App<T>.NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681133);
			App<T>.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681134);
			App<T>.NativeMethodInfoPtr_ShortcutClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681135);
			App<T>.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681136);
			App<T>.NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681137);
			App<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<App<T>>.NativeClassPtr, 100681138);
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x00254D00 File Offset: 0x00252F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260752, XrefRangeEnd = 260765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static App<T> GetApp(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<App<T>>(intPtr3) : null;
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x06008FE6 RID: 36838 RVA: 0x00254D40 File Offset: 0x00252F40
		// (set) Token: 0x06008FE7 RID: 36839 RVA: 0x00254D7C File Offset: 0x00252F7C
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x00254DBC File Offset: 0x00252FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260765, XrefRangeEnd = 260773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x00254E08 File Offset: 0x00253008
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 260811, RefRangeEnd = 260818, XrefRangeStart = 260773, XrefRangeEnd = 260811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x00254E44 File Offset: 0x00253044
		[CallerCount(0)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x00254E78 File Offset: 0x00253078
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 260827, RefRangeEnd = 260833, XrefRangeStart = 260818, XrefRangeEnd = 260827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x00254EB4 File Offset: 0x002530B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260852, RefRangeEnd = 260853, XrefRangeStart = 260833, XrefRangeEnd = 260852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHoveringButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x00254EF0 File Offset: 0x002530F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260853, XrefRangeEnd = 260882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHomeScreenIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x00254F24 File Offset: 0x00253124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260885, RefRangeEnd = 260886, XrefRangeStart = 260882, XrefRangeEnd = 260885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotificationCount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x00254F64 File Offset: 0x00253164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260886, XrefRangeEnd = 260890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x00254FA0 File Offset: 0x002531A0
		[CallerCount(0)]
		public unsafe void ShortcutClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr_ShortcutClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x00254FD4 File Offset: 0x002531D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260896, RefRangeEnd = 260897, XrefRangeStart = 260890, XrefRangeEnd = 260896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x00255024 File Offset: 0x00253224
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 260960, RefRangeEnd = 260967, XrefRangeStart = 260897, XrefRangeEnd = 260960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), App<T>.NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FF3 RID: 36851 RVA: 0x00255070 File Offset: 0x00253270
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 260968, RefRangeEnd = 260976, XrefRangeStart = 260967, XrefRangeEnd = 260968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe App() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<App<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(App<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x000456A2 File Offset: 0x000438A2
		public App(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x06008FF5 RID: 36853 RVA: 0x002550AC File Offset: 0x002532AC
		// (set) Token: 0x06008FF6 RID: 36854 RVA: 0x000456AB File Offset: 0x000438AB
		public unsafe static List<App<T>> Apps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(App<T>.NativeFieldInfoPtr_Apps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<App<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(App<T>.NativeFieldInfoPtr_Apps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x06008FF7 RID: 36855 RVA: 0x002550D4 File Offset: 0x002532D4
		// (set) Token: 0x06008FF8 RID: 36856 RVA: 0x000456BD File Offset: 0x000438BD
		public unsafe string AppName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x002550FC File Offset: 0x002532FC
		// (set) Token: 0x06008FFA RID: 36858 RVA: 0x000456DC File Offset: 0x000438DC
		public unsafe string IconLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_IconLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_IconLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x06008FFB RID: 36859 RVA: 0x00255124 File Offset: 0x00253324
		// (set) Token: 0x06008FFC RID: 36860 RVA: 0x000456FB File Offset: 0x000438FB
		public unsafe Sprite AppIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AppIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06008FFD RID: 36861 RVA: 0x00255154 File Offset: 0x00253354
		// (set) Token: 0x06008FFE RID: 36862 RVA: 0x0004571A File Offset: 0x0004391A
		public unsafe App<T>.EOrientation Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_Orientation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<App<T>.EOrientation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x06008FFF RID: 36863 RVA: 0x0025517C File Offset: 0x0025337C
		// (set) Token: 0x06009000 RID: 36864 RVA: 0x00045748 File Offset: 0x00043948
		public unsafe bool AvailableInTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AvailableInTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_AvailableInTutorial)) = value;
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x06009001 RID: 36865 RVA: 0x002551A4 File Offset: 0x002533A4
		// (set) Token: 0x06009002 RID: 36866 RVA: 0x00045763 File Offset: 0x00043963
		public unsafe RectTransform appContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x06009003 RID: 36867 RVA: 0x002551D4 File Offset: 0x002533D4
		// (set) Token: 0x06009004 RID: 36868 RVA: 0x00045782 File Offset: 0x00043982
		public unsafe RectTransform notificationContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x06009005 RID: 36869 RVA: 0x00255204 File Offset: 0x00253404
		// (set) Token: 0x06009006 RID: 36870 RVA: 0x000457A1 File Offset: 0x000439A1
		public unsafe Text notificationText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_notificationText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x06009007 RID: 36871 RVA: 0x00255234 File Offset: 0x00253434
		// (set) Token: 0x06009008 RID: 36872 RVA: 0x000457C0 File Offset: 0x000439C0
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x06009009 RID: 36873 RVA: 0x0025525C File Offset: 0x0025345C
		// (set) Token: 0x0600900A RID: 36874 RVA: 0x000457DB File Offset: 0x000439DB
		public unsafe Button appIconButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appIconButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(App<T>.NativeFieldInfoPtr_appIconButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006154 RID: 24916
		private static readonly IntPtr NativeFieldInfoPtr_Apps;

		// Token: 0x04006155 RID: 24917
		private static readonly IntPtr NativeFieldInfoPtr_AppName;

		// Token: 0x04006156 RID: 24918
		private static readonly IntPtr NativeFieldInfoPtr_IconLabel;

		// Token: 0x04006157 RID: 24919
		private static readonly IntPtr NativeFieldInfoPtr_AppIcon;

		// Token: 0x04006158 RID: 24920
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x04006159 RID: 24921
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInTutorial;

		// Token: 0x0400615A RID: 24922
		private static readonly IntPtr NativeFieldInfoPtr_appContainer;

		// Token: 0x0400615B RID: 24923
		private static readonly IntPtr NativeFieldInfoPtr_notificationContainer;

		// Token: 0x0400615C RID: 24924
		private static readonly IntPtr NativeFieldInfoPtr_notificationText;

		// Token: 0x0400615D RID: 24925
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400615E RID: 24926
		private static readonly IntPtr NativeFieldInfoPtr_appIconButton;

		// Token: 0x0400615F RID: 24927
		private static readonly IntPtr NativeMethodInfoPtr_GetApp_Public_Static_App_1_T_Int32_0;

		// Token: 0x04006160 RID: 24928
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006161 RID: 24929
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006162 RID: 24930
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006163 RID: 24931
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006164 RID: 24932
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04006165 RID: 24933
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006166 RID: 24934
		private static readonly IntPtr NativeMethodInfoPtr_IsHoveringButton_Private_Boolean_0;

		// Token: 0x04006167 RID: 24935
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHomeScreenIcon_Private_Void_0;

		// Token: 0x04006168 RID: 24936
		private static readonly IntPtr NativeMethodInfoPtr_SetNotificationCount_Public_Void_Int32_0;

		// Token: 0x04006169 RID: 24937
		private static readonly IntPtr NativeMethodInfoPtr_OnPhoneOpened_Protected_Virtual_New_Void_0;

		// Token: 0x0400616A RID: 24938
		private static readonly IntPtr NativeMethodInfoPtr_ShortcutClicked_Private_Void_0;

		// Token: 0x0400616B RID: 24939
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x0400616C RID: 24940
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400616D RID: 24941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000B37 RID: 2871
		[OriginalName("Assembly-CSharp.dll", "", "EOrientation")]
		public enum EOrientation
		{
			// Token: 0x04009150 RID: 37200
			Horizontal,
			// Token: 0x04009151 RID: 37201
			Vertical
		}
	}
}
