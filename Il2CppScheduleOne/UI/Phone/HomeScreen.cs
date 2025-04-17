using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A3 RID: 1699
	public class HomeScreen : PlayerSingleton<HomeScreen>
	{
		// Token: 0x060097D2 RID: 38866 RVA: 0x0026C844 File Offset: 0x0026AA44
		// Note: this type is marked as 'beforefieldinit'.
		static HomeScreen()
		{
			Il2CppClassPointerStore<HomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "HomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr);
			HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			HomeScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "canvas");
			HomeScreen.NativeFieldInfoPtr_timeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "timeText");
			HomeScreen.NativeFieldInfoPtr_appIconContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconContainer");
			HomeScreen.NativeFieldInfoPtr_appIconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIconPrefab");
			HomeScreen.NativeFieldInfoPtr_appIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "appIcons");
			HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "delayedSetOpenRoutine");
			HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682034);
			HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682035);
			HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682036);
			HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682037);
			HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682038);
			HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682039);
			HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682040);
			HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682041);
			HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682042);
			HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682043);
			HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682044);
			HomeScreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682045);
			HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682046);
			HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, 100682047);
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x060097D3 RID: 38867 RVA: 0x0026CA18 File Offset: 0x0026AC18
		// (set) Token: 0x060097D4 RID: 38868 RVA: 0x0026CA54 File Offset: 0x0026AC54
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x0026CA94 File Offset: 0x0026AC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271353, XrefRangeEnd = 271359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097D6 RID: 38870 RVA: 0x0026CAD0 File Offset: 0x0026ACD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271359, XrefRangeEnd = 271402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097D7 RID: 38871 RVA: 0x0026CB1C File Offset: 0x0026AD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271402, XrefRangeEnd = 271421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x0026CB58 File Offset: 0x0026AD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271421, XrefRangeEnd = 271423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097D9 RID: 38873 RVA: 0x0026CB8C File Offset: 0x0026AD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271423, XrefRangeEnd = 271430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097DA RID: 38874 RVA: 0x0026CBC0 File Offset: 0x0026ADC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271430, XrefRangeEnd = 271435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x0026CC1C File Offset: 0x0026AE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271438, RefRangeEnd = 271439, XrefRangeStart = 271435, XrefRangeEnd = 271438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x0026CC5C File Offset: 0x0026AE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271439, XrefRangeEnd = 271442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x0026CC9C File Offset: 0x0026AE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271442, XrefRangeEnd = 271468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x0026CCD8 File Offset: 0x0026AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271468, XrefRangeEnd = 271509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HomeScreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x0026CD14 File Offset: 0x0026AF14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271546, RefRangeEnd = 271547, XrefRangeStart = 271509, XrefRangeEnd = 271546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button GenerateAppIcon<T>(App<T> prog) where T : PlayerSingleton<T>
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prog);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x0026CD64 File Offset: 0x0026AF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271547, XrefRangeEnd = 271557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x00049DC1 File Offset: 0x00047FC1
		public HomeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x060097E2 RID: 38882 RVA: 0x0026CDA0 File Offset: 0x0026AFA0
		// (set) Token: 0x060097E3 RID: 38883 RVA: 0x00049DCA File Offset: 0x00047FCA
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x060097E4 RID: 38884 RVA: 0x0026CDC8 File Offset: 0x0026AFC8
		// (set) Token: 0x060097E5 RID: 38885 RVA: 0x00049DE5 File Offset: 0x00047FE5
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x060097E6 RID: 38886 RVA: 0x0026CDF8 File Offset: 0x0026AFF8
		// (set) Token: 0x060097E7 RID: 38887 RVA: 0x00049E04 File Offset: 0x00048004
		public unsafe Text timeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_timeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x060097E8 RID: 38888 RVA: 0x0026CE28 File Offset: 0x0026B028
		// (set) Token: 0x060097E9 RID: 38889 RVA: 0x00049E23 File Offset: 0x00048023
		public unsafe RectTransform appIconContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x060097EA RID: 38890 RVA: 0x0026CE58 File Offset: 0x0026B058
		// (set) Token: 0x060097EB RID: 38891 RVA: 0x00049E42 File Offset: 0x00048042
		public unsafe GameObject appIconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x060097EC RID: 38892 RVA: 0x0026CE88 File Offset: 0x0026B088
		// (set) Token: 0x060097ED RID: 38893 RVA: 0x00049E61 File Offset: 0x00048061
		public unsafe List<Button> appIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_appIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x060097EE RID: 38894 RVA: 0x0026CEB8 File Offset: 0x0026B0B8
		// (set) Token: 0x060097EF RID: 38895 RVA: 0x00049E80 File Offset: 0x00048080
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006646 RID: 26182
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006647 RID: 26183
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006648 RID: 26184
		private static readonly IntPtr NativeFieldInfoPtr_timeText;

		// Token: 0x04006649 RID: 26185
		private static readonly IntPtr NativeFieldInfoPtr_appIconContainer;

		// Token: 0x0400664A RID: 26186
		private static readonly IntPtr NativeFieldInfoPtr_appIconPrefab;

		// Token: 0x0400664B RID: 26187
		private static readonly IntPtr NativeFieldInfoPtr_appIcons;

		// Token: 0x0400664C RID: 26188
		private static readonly IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x0400664D RID: 26189
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400664E RID: 26190
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400664F RID: 26191
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006650 RID: 26192
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006651 RID: 26193
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006652 RID: 26194
		private static readonly IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x04006653 RID: 26195
		private static readonly IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x04006654 RID: 26196
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04006655 RID: 26197
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006656 RID: 26198
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasActive_Public_Void_Boolean_0;

		// Token: 0x04006657 RID: 26199
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006658 RID: 26200
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006659 RID: 26201
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0;

		// Token: 0x0400665A RID: 26202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B69 RID: 2921
		[ObfuscatedName("ScheduleOne.UI.Phone.HomeScreen+<DelayedSetCanvasActive>d__15")]
		public sealed class _DelayedSetCanvasActive_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600DA9F RID: 55967 RVA: 0x0033CD50 File Offset: 0x0033AF50
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__15()
			{
				Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HomeScreen>.NativeClassPtr, "<DelayedSetCanvasActive>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>1__state");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>2__current");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "delay");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "<>4__this");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, "active");
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682048);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682049);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682050);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682051);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682052);
				HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr, 100682053);
			}

			// Token: 0x0600DAA0 RID: 55968 RVA: 0x0033CE58 File Offset: 0x0033B058
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeScreen._DelayedSetCanvasActive_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAA1 RID: 55969 RVA: 0x0033CEA0 File Offset: 0x0033B0A0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAA2 RID: 55970 RVA: 0x0033CED4 File Offset: 0x0033B0D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271343, XrefRangeEnd = 271348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043D4 RID: 17364
			// (get) Token: 0x0600DAA3 RID: 55971 RVA: 0x0033CF10 File Offset: 0x0033B110
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAA4 RID: 55972 RVA: 0x0033CF50 File Offset: 0x0033B150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271348, XrefRangeEnd = 271353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043D5 RID: 17365
			// (get) Token: 0x0600DAA5 RID: 55973 RVA: 0x0033CF84 File Offset: 0x0033B184
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HomeScreen._DelayedSetCanvasActive_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAA6 RID: 55974 RVA: 0x0006A76F File Offset: 0x0006896F
			public _DelayedSetCanvasActive_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043CF RID: 17359
			// (get) Token: 0x0600DAA7 RID: 55975 RVA: 0x0033CFC4 File Offset: 0x0033B1C4
			// (set) Token: 0x0600DAA8 RID: 55976 RVA: 0x0006A778 File Offset: 0x00068978
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043D0 RID: 17360
			// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x0033CFEC File Offset: 0x0033B1EC
			// (set) Token: 0x0600DAAA RID: 55978 RVA: 0x0006A793 File Offset: 0x00068993
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D1 RID: 17361
			// (get) Token: 0x0600DAAB RID: 55979 RVA: 0x0033D01C File Offset: 0x0033B21C
			// (set) Token: 0x0600DAAC RID: 55980 RVA: 0x0006A7B2 File Offset: 0x000689B2
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170043D2 RID: 17362
			// (get) Token: 0x0600DAAD RID: 55981 RVA: 0x0033D044 File Offset: 0x0033B244
			// (set) Token: 0x0600DAAE RID: 55982 RVA: 0x0006A7CD File Offset: 0x000689CD
			public unsafe HomeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HomeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D3 RID: 17363
			// (get) Token: 0x0600DAAF RID: 55983 RVA: 0x0033D074 File Offset: 0x0033B274
			// (set) Token: 0x0600DAB0 RID: 55984 RVA: 0x0006A7EC File Offset: 0x000689EC
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HomeScreen._DelayedSetCanvasActive_d__15.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x040092B8 RID: 37560
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092B9 RID: 37561
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092BA RID: 37562
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040092BB RID: 37563
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092BC RID: 37564
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x040092BD RID: 37565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092BE RID: 37566
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092BF RID: 37567
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092C0 RID: 37568
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092C1 RID: 37569
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092C2 RID: 37570
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6A RID: 2922
		private sealed class MethodInfoStoreGeneric_GenerateAppIcon_Public_Button_App_1_T_0<T>
		{
			// Token: 0x040092C3 RID: 37571
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HomeScreen.NativeMethodInfoPtr_GenerateAppIcon_Public_Button_App_1_T_0, Il2CppClassPointerStore<HomeScreen>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
