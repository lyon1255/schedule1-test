using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E5 RID: 1253
	public class SpeedZone : MonoBehaviour
	{
		// Token: 0x06006EB0 RID: 28336 RVA: 0x001E95D4 File Offset: 0x001E77D4
		// Note: this type is marked as 'beforefieldinit'.
		static SpeedZone()
		{
			Il2CppClassPointerStore<SpeedZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "SpeedZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr);
			SpeedZone.NativeFieldInfoPtr_speedZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speedZones");
			SpeedZone.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "col");
			SpeedZone.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, "speed");
			SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677292);
			SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677293);
			SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677294);
			SpeedZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677295);
			SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr, 100677296);
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x001E96A4 File Offset: 0x001E78A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220199, XrefRangeEnd = 220209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpeedZone.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x001E96E0 File Offset: 0x001E78E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220209, XrefRangeEnd = 220236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SpeedZone> GetSpeedZones(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr3) : null;
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x001E9720 File Offset: 0x001E7920
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x001E9754 File Offset: 0x001E7954
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x001E9788 File Offset: 0x001E7988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220236, XrefRangeEnd = 220237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeedZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeedZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x0003461B File Offset: 0x0003281B
		public SpeedZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06006EB7 RID: 28343 RVA: 0x001E97C4 File Offset: 0x001E79C4
		// (set) Token: 0x06006EB8 RID: 28344 RVA: 0x00034624 File Offset: 0x00032824
		public unsafe static List<SpeedZone> speedZones
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpeedZone.NativeFieldInfoPtr_speedZones, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpeedZone>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpeedZone.NativeFieldInfoPtr_speedZones, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06006EB9 RID: 28345 RVA: 0x001E97EC File Offset: 0x001E79EC
		// (set) Token: 0x06006EBA RID: 28346 RVA: 0x00034636 File Offset: 0x00032836
		public unsafe BoxCollider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06006EBB RID: 28347 RVA: 0x001E981C File Offset: 0x001E7A1C
		// (set) Token: 0x06006EBC RID: 28348 RVA: 0x00034655 File Offset: 0x00032855
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpeedZone.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04004BBA RID: 19386
		private static readonly IntPtr NativeFieldInfoPtr_speedZones;

		// Token: 0x04004BBB RID: 19387
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004BBC RID: 19388
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04004BBD RID: 19389
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04004BBE RID: 19390
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedZones_Public_Static_List_1_SpeedZone_Vector3_0;

		// Token: 0x04004BBF RID: 19391
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004BC0 RID: 19392
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04004BC1 RID: 19393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
