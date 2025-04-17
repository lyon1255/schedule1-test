using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E6 RID: 1254
	public class Shitbox : LandVehicle
	{
		// Token: 0x06006EBD RID: 28349 RVA: 0x001E9844 File Offset: 0x001E7A44
		// Note: this type is marked as 'beforefieldinit'.
		static Shitbox()
		{
			Il2CppClassPointerStore<Shitbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Shitbox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shitbox>.NativeClassPtr);
			Shitbox.NativeFieldInfoPtr_LoanSharkVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "LoanSharkVisuals");
			Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted");
			Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted");
			Shitbox.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677298);
			Shitbox.NativeMethodInfoPtr_Load_Public_Virtual_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677299);
			Shitbox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677300);
			Shitbox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677301);
			Shitbox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677302);
			Shitbox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677303);
			Shitbox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, 100677304);
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x001E993C File Offset: 0x001E7B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220237, XrefRangeEnd = 220271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x001E9998 File Offset: 0x001E7B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220271, XrefRangeEnd = 220291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(VehicleData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_Load_Public_Virtual_Void_VehicleData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x001E99F8 File Offset: 0x001E7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220291, XrefRangeEnd = 220292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shitbox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shitbox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shitbox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x001E9A34 File Offset: 0x001E7C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220292, XrefRangeEnd = 220293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x001E9A70 File Offset: 0x001E7C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220293, XrefRangeEnd = 220294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x001E9AAC File Offset: 0x001E7CAC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x001E9AE8 File Offset: 0x001E7CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220294, XrefRangeEnd = 220295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shitbox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00034670 File Offset: 0x00032870
		public Shitbox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x001E9B24 File Offset: 0x001E7D24
		// (set) Token: 0x06006EC7 RID: 28359 RVA: 0x00034679 File Offset: 0x00032879
		public unsafe LoanSharkCarVisuals LoanSharkVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_LoanSharkVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoanSharkCarVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_LoanSharkVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x001E9B54 File Offset: 0x001E7D54
		// (set) Token: 0x06006EC9 RID: 28361 RVA: 0x00034698 File Offset: 0x00032898
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x001E9B7C File Offset: 0x001E7D7C
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x000346B3 File Offset: 0x000328B3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004BC2 RID: 19394
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkVisuals;

		// Token: 0x04004BC3 RID: 19395
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004BC4 RID: 19396
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004BC5 RID: 19397
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04004BC6 RID: 19398
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_VehicleData_String_0;

		// Token: 0x04004BC7 RID: 19399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004BC8 RID: 19400
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004BC9 RID: 19401
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004BCA RID: 19402
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004BCB RID: 19403
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A69 RID: 2665
		[Serializable]
		public class LoanSharkVisualsData : SaveData
		{
			// Token: 0x0600D115 RID: 53525 RVA: 0x00321900 File Offset: 0x0031FB00
			// Note: this type is marked as 'beforefieldinit'.
			static LoanSharkVisualsData()
			{
				Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Shitbox>.NativeClassPtr, "LoanSharkVisualsData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr);
				Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, "Enabled");
				Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, "NoteVisible");
				Shitbox.LoanSharkVisualsData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr, 100677305);
			}

			// Token: 0x0600D116 RID: 53526 RVA: 0x00321968 File Offset: 0x0031FB68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 130409, RefRangeEnd = 130410, XrefRangeStart = 130409, XrefRangeEnd = 130410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoanSharkVisualsData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shitbox.LoanSharkVisualsData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shitbox.LoanSharkVisualsData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D117 RID: 53527 RVA: 0x00065C8D File Offset: 0x00063E8D
			public LoanSharkVisualsData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040ED RID: 16621
			// (get) Token: 0x0600D118 RID: 53528 RVA: 0x003219A4 File Offset: 0x0031FBA4
			// (set) Token: 0x0600D119 RID: 53529 RVA: 0x00065C96 File Offset: 0x00063E96
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x170040EE RID: 16622
			// (get) Token: 0x0600D11A RID: 53530 RVA: 0x003219CC File Offset: 0x0031FBCC
			// (set) Token: 0x0600D11B RID: 53531 RVA: 0x00065CB1 File Offset: 0x00063EB1
			public unsafe bool NoteVisible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Shitbox.LoanSharkVisualsData.NativeFieldInfoPtr_NoteVisible)) = value;
				}
			}

			// Token: 0x04008D12 RID: 36114
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x04008D13 RID: 36115
			private static readonly IntPtr NativeFieldInfoPtr_NoteVisible;

			// Token: 0x04008D14 RID: 36116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
