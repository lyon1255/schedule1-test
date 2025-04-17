using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x0200048B RID: 1163
	public class ConstructUpdate_Base : MonoBehaviour
	{
		// Token: 0x060064A6 RID: 25766 RVA: 0x001C7220 File Offset: 0x001C5420
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_Base()
		{
			Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr);
			ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, "MovedConstructable");
			ConstructUpdate_Base.NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676050);
			ConstructUpdate_Base.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676051);
			ConstructUpdate_Base.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676052);
			ConstructUpdate_Base.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676053);
			ConstructUpdate_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676054);
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x001C72C8 File Offset: 0x001C54C8
		public unsafe bool isMoving
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 204413, RefRangeEnd = 204415, XrefRangeStart = 204409, XrefRangeEnd = 204413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_Base.NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x001C7304 File Offset: 0x001C5504
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x001C7340 File Offset: 0x001C5540
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x001C737C File Offset: 0x001C557C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204419, RefRangeEnd = 204421, XrefRangeStart = 204415, XrefRangeEnd = 204419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x001C73B8 File Offset: 0x001C55B8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x0002F968 File Offset: 0x0002DB68
		public ConstructUpdate_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x001C73F4 File Offset: 0x001C55F4
		// (set) Token: 0x060064AE RID: 25774 RVA: 0x0002F971 File Offset: 0x0002DB71
		public unsafe Constructable_GridBased MovedConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044AC RID: 17580
		private static readonly IntPtr NativeFieldInfoPtr_MovedConstructable;

		// Token: 0x040044AD RID: 17581
		private static readonly IntPtr NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0;

		// Token: 0x040044AE RID: 17582
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040044AF RID: 17583
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040044B0 RID: 17584
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0;

		// Token: 0x040044B1 RID: 17585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
