using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020C RID: 524
	public class PackageProductTaskMk2 : Task
	{
		// Token: 0x06002B78 RID: 11128 RVA: 0x000FA190 File Offset: 0x000F8390
		// Note: this type is marked as 'beforefieldinit'.
		static PackageProductTaskMk2()
		{
			Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "PackageProductTaskMk2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr);
			PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "<TaskName>k__BackingField");
			PackageProductTaskMk2.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "station");
			PackageProductTaskMk2.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "Packaging");
			PackageProductTaskMk2.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "Products");
			PackageProductTaskMk2.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668176);
			PackageProductTaskMk2.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668177);
			PackageProductTaskMk2.NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668178);
			PackageProductTaskMk2.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668179);
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x000FA260 File Offset: 0x000F8460
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x000FA2A4 File Offset: 0x000F84A4
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000FA2F4 File Offset: 0x000F84F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122203, RefRangeEnd = 122204, XrefRangeStart = 122139, XrefRangeEnd = 122203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackageProductTaskMk2(PackagingStationMk2 _station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTaskMk2.NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000FA340 File Offset: 0x000F8540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122204, XrefRangeEnd = 122231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00017868 File Offset: 0x00015A68
		public PackageProductTaskMk2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000FA37C File Offset: 0x000F857C
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x00017871 File Offset: 0x00015A71
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x000FA3A4 File Offset: 0x000F85A4
		// (set) Token: 0x06002B81 RID: 11137 RVA: 0x00017890 File Offset: 0x00015A90
		public unsafe PackagingStationMk2 station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationMk2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000FA3D4 File Offset: 0x000F85D4
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x000178AF File Offset: 0x00015AAF
		public unsafe FunctionalPackaging Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000FA404 File Offset: 0x000F8604
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x000178CE File Offset: 0x00015ACE
		public unsafe List<FunctionalProduct> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;
	}
}
