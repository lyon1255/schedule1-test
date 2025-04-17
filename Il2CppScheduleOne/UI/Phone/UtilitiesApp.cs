using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069F RID: 1695
	public class UtilitiesApp : App<UtilitiesApp>
	{
		// Token: 0x0600974D RID: 38733 RVA: 0x0026AEAC File Offset: 0x002690AC
		// Note: this type is marked as 'beforefieldinit'.
		static UtilitiesApp()
		{
			Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "UtilitiesApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr);
			UtilitiesApp.NativeFieldInfoPtr_water_Usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Usage");
			UtilitiesApp.NativeFieldInfoPtr_water_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Cost");
			UtilitiesApp.NativeFieldInfoPtr_water_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "water_Total");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Usage");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Cost");
			UtilitiesApp.NativeFieldInfoPtr_electricity_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "electricity_Total");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_Count");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_EmptyCost");
			UtilitiesApp.NativeFieldInfoPtr_dumpster_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpster_Total");
			UtilitiesApp.NativeFieldInfoPtr_dumpsterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "dumpsterButton");
			UtilitiesApp.NativeFieldInfoPtr_propertySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "propertySelector");
			UtilitiesApp.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, "selectedProperty");
			UtilitiesApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681969);
			UtilitiesApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681970);
			UtilitiesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681971);
			UtilitiesApp.NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681972);
			UtilitiesApp.NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681973);
			UtilitiesApp.NativeMethodInfoPtr_Round_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681974);
			UtilitiesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681975);
			UtilitiesApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr, 100681976);
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x0026B06C File Offset: 0x0026926C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270728, XrefRangeEnd = 270786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x0026B0A8 File Offset: 0x002692A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270786, XrefRangeEnd = 270818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x0026B0E4 File Offset: 0x002692E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270818, XrefRangeEnd = 270823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x0026B120 File Offset: 0x00269320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270823, XrefRangeEnd = 270882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshShownValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x0026B15C File Offset: 0x0026935C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x0026B198 File Offset: 0x00269398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270882, XrefRangeEnd = 270885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Round(float n, float decimals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref n;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilitiesApp.NativeMethodInfoPtr_Round_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x0026B1F0 File Offset: 0x002693F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270885, XrefRangeEnd = 270888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UtilitiesApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009755 RID: 38741 RVA: 0x0026B23C File Offset: 0x0026943C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270888, XrefRangeEnd = 270894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UtilitiesApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilitiesApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilitiesApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x000498E0 File Offset: 0x00047AE0
		public UtilitiesApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x0026B278 File Offset: 0x00269478
		// (set) Token: 0x06009758 RID: 38744 RVA: 0x000498E9 File Offset: 0x00047AE9
		public unsafe Text water_Usage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Usage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Usage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x06009759 RID: 38745 RVA: 0x0026B2A8 File Offset: 0x002694A8
		// (set) Token: 0x0600975A RID: 38746 RVA: 0x00049908 File Offset: 0x00047B08
		public unsafe Text water_Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600975B RID: 38747 RVA: 0x0026B2D8 File Offset: 0x002694D8
		// (set) Token: 0x0600975C RID: 38748 RVA: 0x00049927 File Offset: 0x00047B27
		public unsafe Text water_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_water_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600975D RID: 38749 RVA: 0x0026B308 File Offset: 0x00269508
		// (set) Token: 0x0600975E RID: 38750 RVA: 0x00049946 File Offset: 0x00047B46
		public unsafe Text electricity_Usage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Usage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Usage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6C RID: 11884
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x0026B338 File Offset: 0x00269538
		// (set) Token: 0x06009760 RID: 38752 RVA: 0x00049965 File Offset: 0x00047B65
		public unsafe Text electricity_Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x06009761 RID: 38753 RVA: 0x0026B368 File Offset: 0x00269568
		// (set) Token: 0x06009762 RID: 38754 RVA: 0x00049984 File Offset: 0x00047B84
		public unsafe Text electricity_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_electricity_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x06009763 RID: 38755 RVA: 0x0026B398 File Offset: 0x00269598
		// (set) Token: 0x06009764 RID: 38756 RVA: 0x000499A3 File Offset: 0x00047BA3
		public unsafe Text dumpster_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Count);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Count), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x06009765 RID: 38757 RVA: 0x0026B3C8 File Offset: 0x002695C8
		// (set) Token: 0x06009766 RID: 38758 RVA: 0x000499C2 File Offset: 0x00047BC2
		public unsafe Text dumpster_EmptyCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_EmptyCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x06009767 RID: 38759 RVA: 0x0026B3F8 File Offset: 0x002695F8
		// (set) Token: 0x06009768 RID: 38760 RVA: 0x000499E1 File Offset: 0x00047BE1
		public unsafe Text dumpster_Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Total);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpster_Total), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x06009769 RID: 38761 RVA: 0x0026B428 File Offset: 0x00269628
		// (set) Token: 0x0600976A RID: 38762 RVA: 0x00049A00 File Offset: 0x00047C00
		public unsafe Button dumpsterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpsterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_dumpsterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0600976B RID: 38763 RVA: 0x0026B458 File Offset: 0x00269658
		// (set) Token: 0x0600976C RID: 38764 RVA: 0x00049A1F File Offset: 0x00047C1F
		public unsafe PropertyDropdown propertySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_propertySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_propertySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600976D RID: 38765 RVA: 0x0026B488 File Offset: 0x00269688
		// (set) Token: 0x0600976E RID: 38766 RVA: 0x00049A3E File Offset: 0x00047C3E
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilitiesApp.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065F2 RID: 26098
		private static readonly IntPtr NativeFieldInfoPtr_water_Usage;

		// Token: 0x040065F3 RID: 26099
		private static readonly IntPtr NativeFieldInfoPtr_water_Cost;

		// Token: 0x040065F4 RID: 26100
		private static readonly IntPtr NativeFieldInfoPtr_water_Total;

		// Token: 0x040065F5 RID: 26101
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Usage;

		// Token: 0x040065F6 RID: 26102
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Cost;

		// Token: 0x040065F7 RID: 26103
		private static readonly IntPtr NativeFieldInfoPtr_electricity_Total;

		// Token: 0x040065F8 RID: 26104
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_Count;

		// Token: 0x040065F9 RID: 26105
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_EmptyCost;

		// Token: 0x040065FA RID: 26106
		private static readonly IntPtr NativeFieldInfoPtr_dumpster_Total;

		// Token: 0x040065FB RID: 26107
		private static readonly IntPtr NativeFieldInfoPtr_dumpsterButton;

		// Token: 0x040065FC RID: 26108
		private static readonly IntPtr NativeFieldInfoPtr_propertySelector;

		// Token: 0x040065FD RID: 26109
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x040065FE RID: 26110
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040065FF RID: 26111
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006600 RID: 26112
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006601 RID: 26113
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownValues_Protected_Virtual_New_Void_0;

		// Token: 0x04006602 RID: 26114
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006603 RID: 26115
		private static readonly IntPtr NativeMethodInfoPtr_Round_Private_Single_Single_Single_0;

		// Token: 0x04006604 RID: 26116
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006605 RID: 26117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
