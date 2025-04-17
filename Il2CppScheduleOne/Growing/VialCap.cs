using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000556 RID: 1366
	public class VialCap : Clickable
	{
		// Token: 0x0600783C RID: 30780 RVA: 0x00208374 File Offset: 0x00206574
		// Note: this type is marked as 'beforefieldinit'.
		static VialCap()
		{
			Il2CppClassPointerStore<VialCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "VialCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VialCap>.NativeClassPtr);
			VialCap.NativeFieldInfoPtr__Removed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "<Removed>k__BackingField");
			VialCap.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "Collider");
			VialCap.NativeFieldInfoPtr_RigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "RigidBody");
			VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678400);
			VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678401);
			VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678402);
			VialCap.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678403);
			VialCap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678404);
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x0600783D RID: 30781 RVA: 0x00208444 File Offset: 0x00206644
		// (set) Token: 0x0600783E RID: 30782 RVA: 0x00208480 File Offset: 0x00206680
		public unsafe bool Removed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x002084C0 File Offset: 0x002066C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232219, XrefRangeEnd = 232221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x0020850C File Offset: 0x0020670C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232247, RefRangeEnd = 232248, XrefRangeStart = 232221, XrefRangeEnd = 232247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00208540 File Offset: 0x00206740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232248, XrefRangeEnd = 232249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VialCap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VialCap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x00039036 File Offset: 0x00037236
		public VialCap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x06007843 RID: 30787 RVA: 0x0020857C File Offset: 0x0020677C
		// (set) Token: 0x06007844 RID: 30788 RVA: 0x0003903F File Offset: 0x0003723F
		public unsafe bool _Removed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField)) = value;
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x002085A4 File Offset: 0x002067A4
		// (set) Token: 0x06007846 RID: 30790 RVA: 0x0003905A File Offset: 0x0003725A
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x06007847 RID: 30791 RVA: 0x002085D4 File Offset: 0x002067D4
		// (set) Token: 0x06007848 RID: 30792 RVA: 0x00039079 File Offset: 0x00037279
		public unsafe Rigidbody RigidBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051F2 RID: 20978
		private static readonly IntPtr NativeFieldInfoPtr__Removed_k__BackingField;

		// Token: 0x040051F3 RID: 20979
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x040051F4 RID: 20980
		private static readonly IntPtr NativeFieldInfoPtr_RigidBody;

		// Token: 0x040051F5 RID: 20981
		private static readonly IntPtr NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0;

		// Token: 0x040051F6 RID: 20982
		private static readonly IntPtr NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0;

		// Token: 0x040051F7 RID: 20983
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x040051F8 RID: 20984
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x040051F9 RID: 20985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
