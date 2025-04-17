using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000652 RID: 1618
	public class ArrestNoticeScreen : Singleton<ArrestNoticeScreen>
	{
		// Token: 0x06009056 RID: 36950 RVA: 0x00255F7C File Offset: 0x0025417C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrestNoticeScreen()
		{
			Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ArrestNoticeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr);
			ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "VEHICLE_POSSESSION_TIMEOUT");
			ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "<isOpen>k__BackingField");
			ArrestNoticeScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "Canvas");
			ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CanvasGroup");
			ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CrimeEntryContainer");
			ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "PenaltyEntryContainer");
			ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "CrimeEntryPrefab");
			ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "PenaltyEntryPrefab");
			ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "recordedCrimes");
			ArrestNoticeScreen.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "vehicle");
			ArrestNoticeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681165);
			ArrestNoticeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681166);
			ArrestNoticeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681167);
			ArrestNoticeScreen.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681168);
			ArrestNoticeScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681169);
			ArrestNoticeScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681170);
			ArrestNoticeScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681171);
			ArrestNoticeScreen.NativeMethodInfoPtr_RecordCrimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681172);
			ArrestNoticeScreen.NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681173);
			ArrestNoticeScreen.NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681174);
			ArrestNoticeScreen.NativeMethodInfoPtr_ClearEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681175);
			ArrestNoticeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681176);
			ArrestNoticeScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, 100681177);
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x06009057 RID: 36951 RVA: 0x00256178 File Offset: 0x00254378
		// (set) Token: 0x06009058 RID: 36952 RVA: 0x002561B4 File Offset: 0x002543B4
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x002561F4 File Offset: 0x002543F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261290, XrefRangeEnd = 261326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrestNoticeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600905A RID: 36954 RVA: 0x00256230 File Offset: 0x00254430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261326, XrefRangeEnd = 261338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x00256264 File Offset: 0x00254464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261338, XrefRangeEnd = 261346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x002562A8 File Offset: 0x002544A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261425, RefRangeEnd = 261426, XrefRangeStart = 261346, XrefRangeEnd = 261425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x002562DC File Offset: 0x002544DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261426, XrefRangeEnd = 261434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x00256310 File Offset: 0x00254510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261505, RefRangeEnd = 261507, XrefRangeStart = 261434, XrefRangeEnd = 261505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordCrimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_RecordCrimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x00256344 File Offset: 0x00254544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261591, RefRangeEnd = 261592, XrefRangeStart = 261507, XrefRangeEnd = 261591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPossession(EStealthLevel maxStealthLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxStealthLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x00256384 File Offset: 0x00254584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261644, RefRangeEnd = 261645, XrefRangeStart = 261592, XrefRangeEnd = 261644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfiscateItems(EStealthLevel maxStealthLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxStealthLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x002563C4 File Offset: 0x002545C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261645, XrefRangeEnd = 261658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_ClearEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x002563F8 File Offset: 0x002545F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261658, XrefRangeEnd = 261668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrestNoticeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x00256434 File Offset: 0x00254634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261668, XrefRangeEnd = 261673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x00045B03 File Offset: 0x00043D03
		public ArrestNoticeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x06009065 RID: 36965 RVA: 0x00256474 File Offset: 0x00254674
		// (set) Token: 0x06009066 RID: 36966 RVA: 0x00045B0C File Offset: 0x00043D0C
		public unsafe static float VEHICLE_POSSESSION_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrestNoticeScreen.NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x06009067 RID: 36967 RVA: 0x00256490 File Offset: 0x00254690
		// (set) Token: 0x06009068 RID: 36968 RVA: 0x00045B1A File Offset: 0x00043D1A
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x06009069 RID: 36969 RVA: 0x002564B8 File Offset: 0x002546B8
		// (set) Token: 0x0600906A RID: 36970 RVA: 0x00045B35 File Offset: 0x00043D35
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600906B RID: 36971 RVA: 0x002564E8 File Offset: 0x002546E8
		// (set) Token: 0x0600906C RID: 36972 RVA: 0x00045B54 File Offset: 0x00043D54
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0600906D RID: 36973 RVA: 0x00256518 File Offset: 0x00254718
		// (set) Token: 0x0600906E RID: 36974 RVA: 0x00045B73 File Offset: 0x00043D73
		public unsafe RectTransform CrimeEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x0600906F RID: 36975 RVA: 0x00256548 File Offset: 0x00254748
		// (set) Token: 0x06009070 RID: 36976 RVA: 0x00045B92 File Offset: 0x00043D92
		public unsafe RectTransform PenaltyEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x06009071 RID: 36977 RVA: 0x00256578 File Offset: 0x00254778
		// (set) Token: 0x06009072 RID: 36978 RVA: 0x00045BB1 File Offset: 0x00043DB1
		public unsafe RectTransform CrimeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_CrimeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x06009073 RID: 36979 RVA: 0x002565A8 File Offset: 0x002547A8
		// (set) Token: 0x06009074 RID: 36980 RVA: 0x00045BD0 File Offset: 0x00043DD0
		public unsafe RectTransform PenaltyEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_PenaltyEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x002565D8 File Offset: 0x002547D8
		// (set) Token: 0x06009076 RID: 36982 RVA: 0x00045BEF File Offset: 0x00043DEF
		public unsafe Dictionary<Crime, int> recordedCrimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Crime, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_recordedCrimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x00256608 File Offset: 0x00254808
		// (set) Token: 0x06009078 RID: 36984 RVA: 0x00045C0E File Offset: 0x00043E0E
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400619C RID: 24988
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_POSSESSION_TIMEOUT;

		// Token: 0x0400619D RID: 24989
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x0400619E RID: 24990
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400619F RID: 24991
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x040061A0 RID: 24992
		private static readonly IntPtr NativeFieldInfoPtr_CrimeEntryContainer;

		// Token: 0x040061A1 RID: 24993
		private static readonly IntPtr NativeFieldInfoPtr_PenaltyEntryContainer;

		// Token: 0x040061A2 RID: 24994
		private static readonly IntPtr NativeFieldInfoPtr_CrimeEntryPrefab;

		// Token: 0x040061A3 RID: 24995
		private static readonly IntPtr NativeFieldInfoPtr_PenaltyEntryPrefab;

		// Token: 0x040061A4 RID: 24996
		private static readonly IntPtr NativeFieldInfoPtr_recordedCrimes;

		// Token: 0x040061A5 RID: 24997
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x040061A6 RID: 24998
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040061A7 RID: 24999
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040061A8 RID: 25000
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040061A9 RID: 25001
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x040061AA RID: 25002
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040061AB RID: 25003
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040061AC RID: 25004
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040061AD RID: 25005
		private static readonly IntPtr NativeMethodInfoPtr_RecordCrimes_Public_Void_0;

		// Token: 0x040061AE RID: 25006
		private static readonly IntPtr NativeMethodInfoPtr_RecordPossession_Private_Void_EStealthLevel_0;

		// Token: 0x040061AF RID: 25007
		private static readonly IntPtr NativeMethodInfoPtr_ConfiscateItems_Private_Void_EStealthLevel_0;

		// Token: 0x040061B0 RID: 25008
		private static readonly IntPtr NativeMethodInfoPtr_ClearEntries_Private_Void_0;

		// Token: 0x040061B1 RID: 25009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040061B2 RID: 25010
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B39 RID: 2873
		[ObfuscatedName("ScheduleOne.UI.ArrestNoticeScreen+<<Close>g__CloseRoutine|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D848 RID: 55368 RVA: 0x00335EA0 File Offset: 0x003340A0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique()
			{
				Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrestNoticeScreen>.NativeClassPtr, "<<Close>g__CloseRoutine|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>1__state");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>2__current");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<>4__this");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681178);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681179);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681180);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681181);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681182);
				ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr, 100681183);
			}

			// Token: 0x0600D849 RID: 55369 RVA: 0x00335FA8 File Offset: 0x003341A8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D84A RID: 55370 RVA: 0x00335FF0 File Offset: 0x003341F0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D84B RID: 55371 RVA: 0x00336024 File Offset: 0x00334224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261268, XrefRangeEnd = 261285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004312 RID: 17170
			// (get) Token: 0x0600D84C RID: 55372 RVA: 0x00336060 File Offset: 0x00334260
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D84D RID: 55373 RVA: 0x003360A0 File Offset: 0x003342A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261285, XrefRangeEnd = 261290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004313 RID: 17171
			// (get) Token: 0x0600D84E RID: 55374 RVA: 0x003360D4 File Offset: 0x003342D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D84F RID: 55375 RVA: 0x00069551 File Offset: 0x00067751
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700430D RID: 17165
			// (get) Token: 0x0600D850 RID: 55376 RVA: 0x00336114 File Offset: 0x00334314
			// (set) Token: 0x0600D851 RID: 55377 RVA: 0x0006955A File Offset: 0x0006775A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700430E RID: 17166
			// (get) Token: 0x0600D852 RID: 55378 RVA: 0x0033613C File Offset: 0x0033433C
			// (set) Token: 0x0600D853 RID: 55379 RVA: 0x00069575 File Offset: 0x00067775
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430F RID: 17167
			// (get) Token: 0x0600D854 RID: 55380 RVA: 0x0033616C File Offset: 0x0033436C
			// (set) Token: 0x0600D855 RID: 55381 RVA: 0x00069594 File Offset: 0x00067794
			public unsafe ArrestNoticeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrestNoticeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004310 RID: 17168
			// (get) Token: 0x0600D856 RID: 55382 RVA: 0x0033619C File Offset: 0x0033439C
			// (set) Token: 0x0600D857 RID: 55383 RVA: 0x000695B3 File Offset: 0x000677B3
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004311 RID: 17169
			// (get) Token: 0x0600D858 RID: 55384 RVA: 0x003361C4 File Offset: 0x003343C4
			// (set) Token: 0x0600D859 RID: 55385 RVA: 0x000695CE File Offset: 0x000677CE
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrestNoticeScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObArSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400915B RID: 37211
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400915C RID: 37212
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400915D RID: 37213
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400915E RID: 37214
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400915F RID: 37215
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009160 RID: 37216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009161 RID: 37217
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009162 RID: 37218
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009163 RID: 37219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009164 RID: 37220
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009165 RID: 37221
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
