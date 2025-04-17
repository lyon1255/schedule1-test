using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FF RID: 1279
	public class RoadPath : Object
	{
		// Token: 0x060070DC RID: 28892 RVA: 0x001EFB80 File Offset: 0x001EDD80
		// Note: this type is marked as 'beforefieldinit'.
		static RoadPath()
		{
			Il2CppClassPointerStore<RoadPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "RoadPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPath>.NativeClassPtr);
			RoadPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, "vectorPath");
			RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, 100677504);
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x001EFBD8 File Offset: 0x001EDDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222048, XrefRangeEnd = 222056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x00035955 File Offset: 0x00033B55
		public RoadPath(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x060070DF RID: 28895 RVA: 0x001EFC14 File Offset: 0x001EDE14
		// (set) Token: 0x060070E0 RID: 28896 RVA: 0x0003595E File Offset: 0x00033B5E
		public unsafe List<PathPoint> vectorPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D1B RID: 19739
		private static readonly IntPtr NativeFieldInfoPtr_vectorPath;

		// Token: 0x04004D1C RID: 19740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
