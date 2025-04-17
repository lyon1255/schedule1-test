using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A4 RID: 1700
	public class Phone : PlayerSingleton<Phone>
	{
		// Token: 0x060097F0 RID: 38896 RVA: 0x0026CEE8 File Offset: 0x0026B0E8
		// Note: this type is marked as 'beforefieldinit'.
		static Phone()
		{
			Il2CppClassPointerStore<Phone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "Phone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone>.NativeClassPtr);
			Phone.NativeFieldInfoPtr_ActiveApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "ActiveApp");
			Phone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<IsOpen>k__BackingField");
			Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isHorizontal>k__BackingField");
			Phone.NativeFieldInfoPtr__isOpenable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<isOpenable>k__BackingField");
			Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<FlashlightOn>k__BackingField");
			Phone.NativeFieldInfoPtr_testData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "testData");
			Phone.NativeFieldInfoPtr_testCalller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "testCalller");
			Phone.NativeFieldInfoPtr_phoneModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "phoneModel");
			Phone.NativeFieldInfoPtr_orientation_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Vertical");
			Phone.NativeFieldInfoPtr_orientation_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "orientation_Horizontal");
			Phone.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "raycaster");
			Phone.NativeFieldInfoPtr_PhoneFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "PhoneFlashlight");
			Phone.NativeFieldInfoPtr_FlashlightToggleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "FlashlightToggleSound");
			Phone.NativeFieldInfoPtr_rotationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "rotationTime");
			Phone.NativeFieldInfoPtr_LookOffsetMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "LookOffsetMax");
			Phone.NativeFieldInfoPtr_LookOffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "LookOffsetMin");
			Phone.NativeFieldInfoPtr_OpenVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "OpenVerticalOffset");
			Phone.NativeFieldInfoPtr_onPhoneOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneOpened");
			Phone.NativeFieldInfoPtr_onPhoneClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "onPhoneClosed");
			Phone.NativeFieldInfoPtr_closeApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "closeApps");
			Phone.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "eventSystem");
			Phone.NativeFieldInfoPtr_flashlightVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "flashlightVisibility");
			Phone.NativeFieldInfoPtr_rotationCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "rotationCoroutine");
			Phone.NativeFieldInfoPtr_lookOffsetCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone>.NativeClassPtr, "lookOffsetCoroutine");
			Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682054);
			Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682055);
			Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682056);
			Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682057);
			Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682058);
			Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682059);
			Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682060);
			Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682061);
			Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682062);
			Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682063);
			Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682064);
			Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682065);
			Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682066);
			Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682067);
			Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682068);
			Phone.NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682069);
			Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682070);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682071);
			Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682072);
			Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682073);
			Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682074);
			Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682075);
			Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682076);
			Phone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone>.NativeClassPtr, 100682077);
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x060097F1 RID: 38897 RVA: 0x0026D2D8 File Offset: 0x0026B4D8
		// (set) Token: 0x060097F2 RID: 38898 RVA: 0x0026D314 File Offset: 0x0026B514
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x060097F3 RID: 38899 RVA: 0x0026D354 File Offset: 0x0026B554
		// (set) Token: 0x060097F4 RID: 38900 RVA: 0x0026D390 File Offset: 0x0026B590
		public unsafe bool isHorizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x060097F5 RID: 38901 RVA: 0x0026D3D0 File Offset: 0x0026B5D0
		// (set) Token: 0x060097F6 RID: 38902 RVA: 0x0026D40C File Offset: 0x0026B60C
		public unsafe bool isOpenable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x060097F7 RID: 38903 RVA: 0x0026D44C File Offset: 0x0026B64C
		// (set) Token: 0x060097F8 RID: 38904 RVA: 0x0026D488 File Offset: 0x0026B688
		public unsafe bool FlashlightOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x060097F9 RID: 38905 RVA: 0x0026D4C8 File Offset: 0x0026B6C8
		public unsafe float ScaledLookOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271620, XrefRangeEnd = 271625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x0026D504 File Offset: 0x0026B704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271625, XrefRangeEnd = 271633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097FB RID: 38907 RVA: 0x0026D540 File Offset: 0x0026B740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271633, XrefRangeEnd = 271641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097FC RID: 38908 RVA: 0x0026D58C File Offset: 0x0026B78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271641, XrefRangeEnd = 271654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097FD RID: 38909 RVA: 0x0026D5C8 File Offset: 0x0026B7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271654, XrefRangeEnd = 271683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x0026D604 File Offset: 0x0026B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271683, XrefRangeEnd = 271690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Phone.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097FF RID: 38911 RVA: 0x0026D640 File Offset: 0x0026B840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271690, XrefRangeEnd = 271699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleFlashlight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009800 RID: 38912 RVA: 0x0026D674 File Offset: 0x0026B874
		[CallerCount(0)]
		public unsafe void SetOpenable(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009801 RID: 38913 RVA: 0x0026D6B4 File Offset: 0x0026B8B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271718, RefRangeEnd = 271721, XrefRangeStart = 271699, XrefRangeEnd = 271718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009802 RID: 38914 RVA: 0x0026D6F4 File Offset: 0x0026B8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271729, RefRangeEnd = 271731, XrefRangeStart = 271721, XrefRangeEnd = 271729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsHorizontal(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009803 RID: 38915 RVA: 0x0026D734 File Offset: 0x0026B934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271731, XrefRangeEnd = 271736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetIsHorizontal_Process(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009804 RID: 38916 RVA: 0x0026D780 File Offset: 0x0026B980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271749, RefRangeEnd = 271752, XrefRangeStart = 271736, XrefRangeEnd = 271749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLookOffsetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009805 RID: 38917 RVA: 0x0026D7C0 File Offset: 0x0026B9C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271758, RefRangeEnd = 271759, XrefRangeStart = 271752, XrefRangeEnd = 271758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestCloseApp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_RequestCloseApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009806 RID: 38918 RVA: 0x0026D7F4 File Offset: 0x0026B9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271759, XrefRangeEnd = 271764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetLookOffset_Process(float lookOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lookOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009807 RID: 38919 RVA: 0x0026D840 File Offset: 0x0026BA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271764, XrefRangeEnd = 271781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(out RaycastResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new RaycastResult(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009808 RID: 38920 RVA: 0x0026D8A0 File Offset: 0x0026BAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271781, XrefRangeEnd = 271784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Phone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009809 RID: 38921 RVA: 0x00049E9F File Offset: 0x0004809F
		public Phone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x0600980A RID: 38922 RVA: 0x0026D8DC File Offset: 0x0026BADC
		// (set) Token: 0x0600980B RID: 38923 RVA: 0x00049EA8 File Offset: 0x000480A8
		public unsafe static GameObject ActiveApp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Phone.NativeFieldInfoPtr_ActiveApp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Phone.NativeFieldInfoPtr_ActiveApp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600980C RID: 38924 RVA: 0x0026D904 File Offset: 0x0026BB04
		// (set) Token: 0x0600980D RID: 38925 RVA: 0x00049EBA File Offset: 0x000480BA
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0600980E RID: 38926 RVA: 0x0026D92C File Offset: 0x0026BB2C
		// (set) Token: 0x0600980F RID: 38927 RVA: 0x00049ED5 File Offset: 0x000480D5
		public unsafe bool _isHorizontal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isHorizontal_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x06009810 RID: 38928 RVA: 0x0026D954 File Offset: 0x0026BB54
		// (set) Token: 0x06009811 RID: 38929 RVA: 0x00049EF0 File Offset: 0x000480F0
		public unsafe bool _isOpenable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__isOpenable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x06009812 RID: 38930 RVA: 0x0026D97C File Offset: 0x0026BB7C
		// (set) Token: 0x06009813 RID: 38931 RVA: 0x00049F0B File Offset: 0x0004810B
		public unsafe bool _FlashlightOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr__FlashlightOn_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x06009814 RID: 38932 RVA: 0x0026D9A4 File Offset: 0x0026BBA4
		// (set) Token: 0x06009815 RID: 38933 RVA: 0x00049F26 File Offset: 0x00048126
		public unsafe PhoneCallData testData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x06009816 RID: 38934 RVA: 0x0026D9D4 File Offset: 0x0026BBD4
		// (set) Token: 0x06009817 RID: 38935 RVA: 0x00049F45 File Offset: 0x00048145
		public unsafe CallerID testCalller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testCalller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_testCalller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x06009818 RID: 38936 RVA: 0x0026DA04 File Offset: 0x0026BC04
		// (set) Token: 0x06009819 RID: 38937 RVA: 0x00049F64 File Offset: 0x00048164
		public unsafe GameObject phoneModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_phoneModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0600981A RID: 38938 RVA: 0x0026DA34 File Offset: 0x0026BC34
		// (set) Token: 0x0600981B RID: 38939 RVA: 0x00049F83 File Offset: 0x00048183
		public unsafe Transform orientation_Vertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Vertical), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0600981C RID: 38940 RVA: 0x0026DA64 File Offset: 0x0026BC64
		// (set) Token: 0x0600981D RID: 38941 RVA: 0x00049FA2 File Offset: 0x000481A2
		public unsafe Transform orientation_Horizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_orientation_Horizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600981E RID: 38942 RVA: 0x0026DA94 File Offset: 0x0026BC94
		// (set) Token: 0x0600981F RID: 38943 RVA: 0x00049FC1 File Offset: 0x000481C1
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x06009820 RID: 38944 RVA: 0x0026DAC4 File Offset: 0x0026BCC4
		// (set) Token: 0x06009821 RID: 38945 RVA: 0x00049FE0 File Offset: 0x000481E0
		public unsafe GameObject PhoneFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_PhoneFlashlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x06009822 RID: 38946 RVA: 0x0026DAF4 File Offset: 0x0026BCF4
		// (set) Token: 0x06009823 RID: 38947 RVA: 0x00049FFF File Offset: 0x000481FF
		public unsafe AudioSourceController FlashlightToggleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_FlashlightToggleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x06009824 RID: 38948 RVA: 0x0026DB24 File Offset: 0x0026BD24
		// (set) Token: 0x06009825 RID: 38949 RVA: 0x0004A01E File Offset: 0x0004821E
		public unsafe float rotationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationTime)) = value;
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x06009826 RID: 38950 RVA: 0x0026DB4C File Offset: 0x0026BD4C
		// (set) Token: 0x06009827 RID: 38951 RVA: 0x0004A039 File Offset: 0x00048239
		public unsafe float LookOffsetMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMax)) = value;
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x0026DB74 File Offset: 0x0026BD74
		// (set) Token: 0x06009829 RID: 38953 RVA: 0x0004A054 File Offset: 0x00048254
		public unsafe float LookOffsetMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_LookOffsetMin)) = value;
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0600982A RID: 38954 RVA: 0x0026DB9C File Offset: 0x0026BD9C
		// (set) Token: 0x0600982B RID: 38955 RVA: 0x0004A06F File Offset: 0x0004826F
		public unsafe float OpenVerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_OpenVerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_OpenVerticalOffset)) = value;
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600982C RID: 38956 RVA: 0x0026DBC4 File Offset: 0x0026BDC4
		// (set) Token: 0x0600982D RID: 38957 RVA: 0x0004A08A File Offset: 0x0004828A
		public unsafe Action onPhoneOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600982E RID: 38958 RVA: 0x0026DBF4 File Offset: 0x0026BDF4
		// (set) Token: 0x0600982F RID: 38959 RVA: 0x0004A0A9 File Offset: 0x000482A9
		public unsafe Action onPhoneClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_onPhoneClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x06009830 RID: 38960 RVA: 0x0026DC24 File Offset: 0x0026BE24
		// (set) Token: 0x06009831 RID: 38961 RVA: 0x0004A0C8 File Offset: 0x000482C8
		public unsafe Action closeApps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_closeApps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x06009832 RID: 38962 RVA: 0x0026DC54 File Offset: 0x0026BE54
		// (set) Token: 0x06009833 RID: 38963 RVA: 0x0004A0E7 File Offset: 0x000482E7
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x06009834 RID: 38964 RVA: 0x0026DC84 File Offset: 0x0026BE84
		// (set) Token: 0x06009835 RID: 38965 RVA: 0x0004A106 File Offset: 0x00048306
		public unsafe VisibilityAttribute flashlightVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_flashlightVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x06009836 RID: 38966 RVA: 0x0026DCB4 File Offset: 0x0026BEB4
		// (set) Token: 0x06009837 RID: 38967 RVA: 0x0004A125 File Offset: 0x00048325
		public unsafe Coroutine rotationCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_rotationCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x06009838 RID: 38968 RVA: 0x0026DCE4 File Offset: 0x0026BEE4
		// (set) Token: 0x06009839 RID: 38969 RVA: 0x0004A144 File Offset: 0x00048344
		public unsafe Coroutine lookOffsetCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone.NativeFieldInfoPtr_lookOffsetCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400665B RID: 26203
		private static readonly IntPtr NativeFieldInfoPtr_ActiveApp;

		// Token: 0x0400665C RID: 26204
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400665D RID: 26205
		private static readonly IntPtr NativeFieldInfoPtr__isHorizontal_k__BackingField;

		// Token: 0x0400665E RID: 26206
		private static readonly IntPtr NativeFieldInfoPtr__isOpenable_k__BackingField;

		// Token: 0x0400665F RID: 26207
		private static readonly IntPtr NativeFieldInfoPtr__FlashlightOn_k__BackingField;

		// Token: 0x04006660 RID: 26208
		private static readonly IntPtr NativeFieldInfoPtr_testData;

		// Token: 0x04006661 RID: 26209
		private static readonly IntPtr NativeFieldInfoPtr_testCalller;

		// Token: 0x04006662 RID: 26210
		private static readonly IntPtr NativeFieldInfoPtr_phoneModel;

		// Token: 0x04006663 RID: 26211
		private static readonly IntPtr NativeFieldInfoPtr_orientation_Vertical;

		// Token: 0x04006664 RID: 26212
		private static readonly IntPtr NativeFieldInfoPtr_orientation_Horizontal;

		// Token: 0x04006665 RID: 26213
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04006666 RID: 26214
		private static readonly IntPtr NativeFieldInfoPtr_PhoneFlashlight;

		// Token: 0x04006667 RID: 26215
		private static readonly IntPtr NativeFieldInfoPtr_FlashlightToggleSound;

		// Token: 0x04006668 RID: 26216
		private static readonly IntPtr NativeFieldInfoPtr_rotationTime;

		// Token: 0x04006669 RID: 26217
		private static readonly IntPtr NativeFieldInfoPtr_LookOffsetMax;

		// Token: 0x0400666A RID: 26218
		private static readonly IntPtr NativeFieldInfoPtr_LookOffsetMin;

		// Token: 0x0400666B RID: 26219
		private static readonly IntPtr NativeFieldInfoPtr_OpenVerticalOffset;

		// Token: 0x0400666C RID: 26220
		private static readonly IntPtr NativeFieldInfoPtr_onPhoneOpened;

		// Token: 0x0400666D RID: 26221
		private static readonly IntPtr NativeFieldInfoPtr_onPhoneClosed;

		// Token: 0x0400666E RID: 26222
		private static readonly IntPtr NativeFieldInfoPtr_closeApps;

		// Token: 0x0400666F RID: 26223
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04006670 RID: 26224
		private static readonly IntPtr NativeFieldInfoPtr_flashlightVisibility;

		// Token: 0x04006671 RID: 26225
		private static readonly IntPtr NativeFieldInfoPtr_rotationCoroutine;

		// Token: 0x04006672 RID: 26226
		private static readonly IntPtr NativeFieldInfoPtr_lookOffsetCoroutine;

		// Token: 0x04006673 RID: 26227
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006674 RID: 26228
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006675 RID: 26229
		private static readonly IntPtr NativeMethodInfoPtr_get_isHorizontal_Public_get_Boolean_0;

		// Token: 0x04006676 RID: 26230
		private static readonly IntPtr NativeMethodInfoPtr_set_isHorizontal_Protected_set_Void_Boolean_0;

		// Token: 0x04006677 RID: 26231
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpenable_Public_get_Boolean_0;

		// Token: 0x04006678 RID: 26232
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpenable_Protected_set_Void_Boolean_0;

		// Token: 0x04006679 RID: 26233
		private static readonly IntPtr NativeMethodInfoPtr_get_FlashlightOn_Public_get_Boolean_0;

		// Token: 0x0400667A RID: 26234
		private static readonly IntPtr NativeMethodInfoPtr_set_FlashlightOn_Protected_set_Void_Boolean_0;

		// Token: 0x0400667B RID: 26235
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaledLookOffset_Public_get_Single_0;

		// Token: 0x0400667C RID: 26236
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400667D RID: 26237
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400667E RID: 26238
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400667F RID: 26239
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006680 RID: 26240
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006681 RID: 26241
		private static readonly IntPtr NativeMethodInfoPtr_ToggleFlashlight_Private_Void_0;

		// Token: 0x04006682 RID: 26242
		private static readonly IntPtr NativeMethodInfoPtr_SetOpenable_Public_Void_Boolean_0;

		// Token: 0x04006683 RID: 26243
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006684 RID: 26244
		private static readonly IntPtr NativeMethodInfoPtr_SetIsHorizontal_Public_Void_Boolean_0;

		// Token: 0x04006685 RID: 26245
		private static readonly IntPtr NativeMethodInfoPtr_SetIsHorizontal_Process_Protected_IEnumerator_Boolean_0;

		// Token: 0x04006686 RID: 26246
		private static readonly IntPtr NativeMethodInfoPtr_SetLookOffsetMultiplier_Public_Void_Single_0;

		// Token: 0x04006687 RID: 26247
		private static readonly IntPtr NativeMethodInfoPtr_RequestCloseApp_Public_Void_0;

		// Token: 0x04006688 RID: 26248
		private static readonly IntPtr NativeMethodInfoPtr_SetLookOffset_Process_Protected_IEnumerator_Single_0;

		// Token: 0x04006689 RID: 26249
		private static readonly IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_byref_RaycastResult_0;

		// Token: 0x0400668A RID: 26250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B6B RID: 2923
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetIsHorizontal_Process>d__46")]
		public sealed class _SetIsHorizontal_Process_d__46 : Il2CppSystem.Object
		{
			// Token: 0x0600DAB2 RID: 55986 RVA: 0x0033D0F0 File Offset: 0x0033B2F0
			// Note: this type is marked as 'beforefieldinit'.
			static _SetIsHorizontal_Process_d__46()
			{
				Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetIsHorizontal_Process>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr);
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>1__state");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>2__current");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<>4__this");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "h");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<adjustedRotationTime>5__2");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<startRotation>5__3");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<endRotation>5__4");
				Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, "<i>5__5");
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682078);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682079);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682080);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682081);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682082);
				Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr, 100682083);
			}

			// Token: 0x0600DAB3 RID: 55987 RVA: 0x0033D234 File Offset: 0x0033B434
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetIsHorizontal_Process_d__46(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetIsHorizontal_Process_d__46>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAB4 RID: 55988 RVA: 0x0033D27C File Offset: 0x0033B47C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAB5 RID: 55989 RVA: 0x0033D2B0 File Offset: 0x0033B4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271557, XrefRangeEnd = 271586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043DE RID: 17374
			// (get) Token: 0x0600DAB6 RID: 55990 RVA: 0x0033D2EC File Offset: 0x0033B4EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAB7 RID: 55991 RVA: 0x0033D32C File Offset: 0x0033B52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271586, XrefRangeEnd = 271591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043DF RID: 17375
			// (get) Token: 0x0600DAB8 RID: 55992 RVA: 0x0033D360 File Offset: 0x0033B560
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetIsHorizontal_Process_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAB9 RID: 55993 RVA: 0x0006A807 File Offset: 0x00068A07
			public _SetIsHorizontal_Process_d__46(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D6 RID: 17366
			// (get) Token: 0x0600DABA RID: 55994 RVA: 0x0033D3A0 File Offset: 0x0033B5A0
			// (set) Token: 0x0600DABB RID: 55995 RVA: 0x0006A810 File Offset: 0x00068A10
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043D7 RID: 17367
			// (get) Token: 0x0600DABC RID: 55996 RVA: 0x0033D3C8 File Offset: 0x0033B5C8
			// (set) Token: 0x0600DABD RID: 55997 RVA: 0x0006A82B File Offset: 0x00068A2B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D8 RID: 17368
			// (get) Token: 0x0600DABE RID: 55998 RVA: 0x0033D3F8 File Offset: 0x0033B5F8
			// (set) Token: 0x0600DABF RID: 55999 RVA: 0x0006A84A File Offset: 0x00068A4A
			public unsafe Phone __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D9 RID: 17369
			// (get) Token: 0x0600DAC0 RID: 56000 RVA: 0x0033D428 File Offset: 0x0033B628
			// (set) Token: 0x0600DAC1 RID: 56001 RVA: 0x0006A869 File Offset: 0x00068A69
			public unsafe bool h
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr_h)) = value;
				}
			}

			// Token: 0x170043DA RID: 17370
			// (get) Token: 0x0600DAC2 RID: 56002 RVA: 0x0033D450 File Offset: 0x0033B650
			// (set) Token: 0x0600DAC3 RID: 56003 RVA: 0x0006A884 File Offset: 0x00068A84
			public unsafe float _adjustedRotationTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__adjustedRotationTime_5__2)) = value;
				}
			}

			// Token: 0x170043DB RID: 17371
			// (get) Token: 0x0600DAC4 RID: 56004 RVA: 0x0033D478 File Offset: 0x0033B678
			// (set) Token: 0x0600DAC5 RID: 56005 RVA: 0x0006A89F File Offset: 0x00068A9F
			public unsafe Quaternion _startRotation_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__startRotation_5__3)) = value;
				}
			}

			// Token: 0x170043DC RID: 17372
			// (get) Token: 0x0600DAC6 RID: 56006 RVA: 0x0033D4A0 File Offset: 0x0033B6A0
			// (set) Token: 0x0600DAC7 RID: 56007 RVA: 0x0006A8BA File Offset: 0x00068ABA
			public unsafe Quaternion _endRotation_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__endRotation_5__4)) = value;
				}
			}

			// Token: 0x170043DD RID: 17373
			// (get) Token: 0x0600DAC8 RID: 56008 RVA: 0x0033D4C8 File Offset: 0x0033B6C8
			// (set) Token: 0x0600DAC9 RID: 56009 RVA: 0x0006A8D5 File Offset: 0x00068AD5
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetIsHorizontal_Process_d__46.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040092C4 RID: 37572
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092C5 RID: 37573
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092C6 RID: 37574
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092C7 RID: 37575
			private static readonly IntPtr NativeFieldInfoPtr_h;

			// Token: 0x040092C8 RID: 37576
			private static readonly IntPtr NativeFieldInfoPtr__adjustedRotationTime_5__2;

			// Token: 0x040092C9 RID: 37577
			private static readonly IntPtr NativeFieldInfoPtr__startRotation_5__3;

			// Token: 0x040092CA RID: 37578
			private static readonly IntPtr NativeFieldInfoPtr__endRotation_5__4;

			// Token: 0x040092CB RID: 37579
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040092CC RID: 37580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092CD RID: 37581
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092CE RID: 37582
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092CF RID: 37583
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092D0 RID: 37584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092D1 RID: 37585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6C RID: 2924
		[ObfuscatedName("ScheduleOne.UI.Phone.Phone+<SetLookOffset_Process>d__50")]
		public sealed class _SetLookOffset_Process_d__50 : Il2CppSystem.Object
		{
			// Token: 0x0600DACA RID: 56010 RVA: 0x0033D4F0 File Offset: 0x0033B6F0
			// Note: this type is marked as 'beforefieldinit'.
			static _SetLookOffset_Process_d__50()
			{
				Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Phone>.NativeClassPtr, "<SetLookOffset_Process>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr);
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>1__state");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>2__current");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<>4__this");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "lookOffset");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<startOffset>5__2");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<endOffset>5__3");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<moveTime>5__4");
				Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, "<i>5__5");
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682084);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682085);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682086);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682087);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682088);
				Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr, 100682089);
			}

			// Token: 0x0600DACB RID: 56011 RVA: 0x0033D634 File Offset: 0x0033B834
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetLookOffset_Process_d__50(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Phone._SetLookOffset_Process_d__50>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DACC RID: 56012 RVA: 0x0033D67C File Offset: 0x0033B87C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DACD RID: 56013 RVA: 0x0033D6B0 File Offset: 0x0033B8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271591, XrefRangeEnd = 271615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043E8 RID: 17384
			// (get) Token: 0x0600DACE RID: 56014 RVA: 0x0033D6EC File Offset: 0x0033B8EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DACF RID: 56015 RVA: 0x0033D72C File Offset: 0x0033B92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271615, XrefRangeEnd = 271620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043E9 RID: 17385
			// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x0033D760 File Offset: 0x0033B960
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Phone._SetLookOffset_Process_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAD1 RID: 56017 RVA: 0x0006A8F0 File Offset: 0x00068AF0
			public _SetLookOffset_Process_d__50(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E0 RID: 17376
			// (get) Token: 0x0600DAD2 RID: 56018 RVA: 0x0033D7A0 File Offset: 0x0033B9A0
			// (set) Token: 0x0600DAD3 RID: 56019 RVA: 0x0006A8F9 File Offset: 0x00068AF9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043E1 RID: 17377
			// (get) Token: 0x0600DAD4 RID: 56020 RVA: 0x0033D7C8 File Offset: 0x0033B9C8
			// (set) Token: 0x0600DAD5 RID: 56021 RVA: 0x0006A914 File Offset: 0x00068B14
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E2 RID: 17378
			// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x0033D7F8 File Offset: 0x0033B9F8
			// (set) Token: 0x0600DAD7 RID: 56023 RVA: 0x0006A933 File Offset: 0x00068B33
			public unsafe Phone __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Phone>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E3 RID: 17379
			// (get) Token: 0x0600DAD8 RID: 56024 RVA: 0x0033D828 File Offset: 0x0033BA28
			// (set) Token: 0x0600DAD9 RID: 56025 RVA: 0x0006A952 File Offset: 0x00068B52
			public unsafe float lookOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr_lookOffset)) = value;
				}
			}

			// Token: 0x170043E4 RID: 17380
			// (get) Token: 0x0600DADA RID: 56026 RVA: 0x0033D850 File Offset: 0x0033BA50
			// (set) Token: 0x0600DADB RID: 56027 RVA: 0x0006A96D File Offset: 0x00068B6D
			public unsafe float _startOffset_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__startOffset_5__2)) = value;
				}
			}

			// Token: 0x170043E5 RID: 17381
			// (get) Token: 0x0600DADC RID: 56028 RVA: 0x0033D878 File Offset: 0x0033BA78
			// (set) Token: 0x0600DADD RID: 56029 RVA: 0x0006A988 File Offset: 0x00068B88
			public unsafe float _endOffset_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__endOffset_5__3)) = value;
				}
			}

			// Token: 0x170043E6 RID: 17382
			// (get) Token: 0x0600DADE RID: 56030 RVA: 0x0033D8A0 File Offset: 0x0033BAA0
			// (set) Token: 0x0600DADF RID: 56031 RVA: 0x0006A9A3 File Offset: 0x00068BA3
			public unsafe float _moveTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__moveTime_5__4)) = value;
				}
			}

			// Token: 0x170043E7 RID: 17383
			// (get) Token: 0x0600DAE0 RID: 56032 RVA: 0x0033D8C8 File Offset: 0x0033BAC8
			// (set) Token: 0x0600DAE1 RID: 56033 RVA: 0x0006A9BE File Offset: 0x00068BBE
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Phone._SetLookOffset_Process_d__50.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040092D2 RID: 37586
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092D3 RID: 37587
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092D4 RID: 37588
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092D5 RID: 37589
			private static readonly IntPtr NativeFieldInfoPtr_lookOffset;

			// Token: 0x040092D6 RID: 37590
			private static readonly IntPtr NativeFieldInfoPtr__startOffset_5__2;

			// Token: 0x040092D7 RID: 37591
			private static readonly IntPtr NativeFieldInfoPtr__endOffset_5__3;

			// Token: 0x040092D8 RID: 37592
			private static readonly IntPtr NativeFieldInfoPtr__moveTime_5__4;

			// Token: 0x040092D9 RID: 37593
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040092DA RID: 37594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092DB RID: 37595
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092DC RID: 37596
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092DD RID: 37597
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092DE RID: 37598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092DF RID: 37599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
