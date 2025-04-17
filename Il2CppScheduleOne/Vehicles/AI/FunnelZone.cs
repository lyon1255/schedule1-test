using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FC RID: 1276
	public class FunnelZone : MonoBehaviour
	{
		// Token: 0x060070B7 RID: 28855 RVA: 0x001EF330 File Offset: 0x001ED530
		// Note: this type is marked as 'beforefieldinit'.
		static FunnelZone()
		{
			Il2CppClassPointerStore<FunnelZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "FunnelZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr);
			FunnelZone.NativeFieldInfoPtr_funnelZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "funnelZones");
			FunnelZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "col");
			FunnelZone.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, "entryPoint");
			FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677453);
			FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677454);
			FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677455);
			FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr, 100677456);
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x001EF3EC File Offset: 0x001ED5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221672, XrefRangeEnd = 221682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunnelZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x001EF428 File Offset: 0x001ED628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221682, XrefRangeEnd = 221700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FunnelZone GetFunnelZone(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FunnelZone>(intPtr3) : null;
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x001EF468 File Offset: 0x001ED668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221700, XrefRangeEnd = 221712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x001EF49C File Offset: 0x001ED69C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunnelZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunnelZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunnelZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x0003587D File Offset: 0x00033A7D
		public FunnelZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x060070BD RID: 28861 RVA: 0x001EF4D8 File Offset: 0x001ED6D8
		// (set) Token: 0x060070BE RID: 28862 RVA: 0x00035886 File Offset: 0x00033A86
		public unsafe static List<FunnelZone> funnelZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FunnelZone.NativeFieldInfoPtr_funnelZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunnelZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FunnelZone.NativeFieldInfoPtr_funnelZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x001EF500 File Offset: 0x001ED700
		// (set) Token: 0x060070C0 RID: 28864 RVA: 0x00035898 File Offset: 0x00033A98
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x060070C1 RID: 28865 RVA: 0x001EF530 File Offset: 0x001ED730
		// (set) Token: 0x060070C2 RID: 28866 RVA: 0x000358B7 File Offset: 0x00033AB7
		public unsafe Transform entryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunnelZone.NativeFieldInfoPtr_entryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D04 RID: 19716
		private static readonly IntPtr NativeFieldInfoPtr_funnelZones;

		// Token: 0x04004D05 RID: 19717
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004D06 RID: 19718
		private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04004D07 RID: 19719
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004D08 RID: 19720
		private static readonly IntPtr NativeMethodInfoPtr_GetFunnelZone_Public_Static_FunnelZone_Vector3_0;

		// Token: 0x04004D09 RID: 19721
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004D0A RID: 19722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
