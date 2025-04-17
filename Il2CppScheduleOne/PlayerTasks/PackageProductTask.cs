using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020B RID: 523
	public class PackageProductTask : Task
	{
		// Token: 0x06002B66 RID: 11110 RVA: 0x000F9DC4 File Offset: 0x000F7FC4
		// Note: this type is marked as 'beforefieldinit'.
		static PackageProductTask()
		{
			Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "PackageProductTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr);
			PackageProductTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "<TaskName>k__BackingField");
			PackageProductTask.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "station");
			PackageProductTask.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "Packaging");
			PackageProductTask.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, "Products");
			PackageProductTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668168);
			PackageProductTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668169);
			PackageProductTask.NativeMethodInfoPtr__ctor_Public_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668170);
			PackageProductTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668171);
			PackageProductTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668172);
			PackageProductTask.NativeMethodInfoPtr_FullyPacked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668173);
			PackageProductTask.NativeMethodInfoPtr_Sealed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668174);
			PackageProductTask.NativeMethodInfoPtr_ReachedOutput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr, 100668175);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000F9EE4 File Offset: 0x000F80E4
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x000F9F28 File Offset: 0x000F8128
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000F9F78 File Offset: 0x000F8178
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122090, RefRangeEnd = 122093, XrefRangeStart = 121983, XrefRangeEnd = 122090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackageProductTask(PackagingStation _station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageProductTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr__ctor_Public_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000F9FC4 File Offset: 0x000F81C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122093, XrefRangeEnd = 122129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000FA000 File Offset: 0x000F8200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122129, XrefRangeEnd = 122132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x000FA03C File Offset: 0x000F823C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122132, XrefRangeEnd = 122134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr_FullyPacked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000FA070 File Offset: 0x000F8270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122134, XrefRangeEnd = 122139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sealed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr_Sealed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000FA0A4 File Offset: 0x000F82A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38034, RefRangeEnd = 38039, XrefRangeStart = 38034, XrefRangeEnd = 38039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReachedOutput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTask.NativeMethodInfoPtr_ReachedOutput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x000177E3 File Offset: 0x000159E3
		public PackageProductTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000FA0D8 File Offset: 0x000F82D8
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x000177EC File Offset: 0x000159EC
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000FA100 File Offset: 0x000F8300
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x0001780B File Offset: 0x00015A0B
		public unsafe PackagingStation station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x000FA130 File Offset: 0x000F8330
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x0001782A File Offset: 0x00015A2A
		public unsafe FunctionalPackaging Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x000FA160 File Offset: 0x000F8360
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x00017849 File Offset: 0x00015A49
		public unsafe List<FunctionalProduct> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTask.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PackagingStation_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Private_Void_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_Sealed_Private_Void_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_ReachedOutput_Private_Void_0;
	}
}
