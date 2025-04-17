using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054B RID: 1355
	public class RoadCracksRandomizer : MonoBehaviour
	{
		// Token: 0x060077A8 RID: 30632 RVA: 0x00206C24 File Offset: 0x00204E24
		// Note: this type is marked as 'beforefieldinit'.
		static RoadCracksRandomizer()
		{
			Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RoadCracksRandomizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr);
			RoadCracksRandomizer.NativeFieldInfoPtr_Cracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "Cracks");
			RoadCracksRandomizer.NativeFieldInfoPtr_MinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MinCount");
			RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MaxCount");
			RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100678360);
			RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100678361);
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00206CB8 File Offset: 0x00204EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231838, XrefRangeEnd = 231863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00206CEC File Offset: 0x00204EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231863, XrefRangeEnd = 231864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCracksRandomizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x00038A97 File Offset: 0x00036C97
		public RoadCracksRandomizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x00206D28 File Offset: 0x00204F28
		// (set) Token: 0x060077AD RID: 30637 RVA: 0x00038AA0 File Offset: 0x00036CA0
		public unsafe Il2CppReferenceArray<Transform> Cracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x00206D58 File Offset: 0x00204F58
		// (set) Token: 0x060077AF RID: 30639 RVA: 0x00038ABF File Offset: 0x00036CBF
		public unsafe int MinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount)) = value;
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x060077B0 RID: 30640 RVA: 0x00206D80 File Offset: 0x00204F80
		// (set) Token: 0x060077B1 RID: 30641 RVA: 0x00038ADA File Offset: 0x00036CDA
		public unsafe int MaxCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount)) = value;
			}
		}

		// Token: 0x040051A3 RID: 20899
		private static readonly IntPtr NativeFieldInfoPtr_Cracks;

		// Token: 0x040051A4 RID: 20900
		private static readonly IntPtr NativeFieldInfoPtr_MinCount;

		// Token: 0x040051A5 RID: 20901
		private static readonly IntPtr NativeFieldInfoPtr_MaxCount;

		// Token: 0x040051A6 RID: 20902
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Private_Void_0;

		// Token: 0x040051A7 RID: 20903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
