using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000502 RID: 1282
	public class PathPoint : MonoBehaviour
	{
		// Token: 0x060070EE RID: 28910 RVA: 0x001EFDCC File Offset: 0x001EDFCC
		// Note: this type is marked as 'beforefieldinit'.
		static PathPoint()
		{
			Il2CppClassPointerStore<PathPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPoint>.NativeClassPtr);
			PathPoint.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "connections");
			PathPoint.NativeFieldInfoPtr_unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "unique");
			PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, 100677506);
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x001EFE38 File Offset: 0x001EE038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222056, XrefRangeEnd = 222064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x00035A2C File Offset: 0x00033C2C
		public PathPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x001EFE74 File Offset: 0x001EE074
		// (set) Token: 0x060070F2 RID: 28914 RVA: 0x00035A35 File Offset: 0x00033C35
		public unsafe List<PathPoint> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x060070F3 RID: 28915 RVA: 0x001EFEA4 File Offset: 0x001EE0A4
		// (set) Token: 0x060070F4 RID: 28916 RVA: 0x00035A54 File Offset: 0x00033C54
		public unsafe bool unique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique)) = value;
			}
		}

		// Token: 0x04004D22 RID: 19746
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04004D23 RID: 19747
		private static readonly IntPtr NativeFieldInfoPtr_unique;

		// Token: 0x04004D24 RID: 19748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
