using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200041B RID: 1051
	public class SupplierLocationConfiguration : MonoBehaviour
	{
		// Token: 0x06005C4F RID: 23631 RVA: 0x001AB5DC File Offset: 0x001A97DC
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocationConfiguration()
		{
			Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocationConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr);
			SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, "SupplierID");
			SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675075);
			SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675076);
			SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100675077);
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x001AB65C File Offset: 0x001A985C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194670, XrefRangeEnd = 194673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x001AB690 File Offset: 0x001A9890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194673, XrefRangeEnd = 194676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x001AB6C4 File Offset: 0x001A98C4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocationConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x0002B828 File Offset: 0x00029A28
		public SupplierLocationConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06005C54 RID: 23636 RVA: 0x001AB700 File Offset: 0x001A9900
		// (set) Token: 0x06005C55 RID: 23637 RVA: 0x0002B831 File Offset: 0x00029A31
		public unsafe string SupplierID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003F27 RID: 16167
		private static readonly IntPtr NativeFieldInfoPtr_SupplierID;

		// Token: 0x04003F28 RID: 16168
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04003F29 RID: 16169
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04003F2A RID: 16170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
