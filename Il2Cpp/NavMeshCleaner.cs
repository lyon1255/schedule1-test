using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000025 RID: 37
	public class NavMeshCleaner : MonoBehaviour
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00078F98 File Offset: 0x00077198
		// Note: this type is marked as 'beforefieldinit'.
		static NavMeshCleaner()
		{
			Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NavMeshCleaner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr);
			NavMeshCleaner.NativeFieldInfoPtr_m_WalkablePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_WalkablePoint");
			NavMeshCleaner.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_Height");
			NavMeshCleaner.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_Offset");
			NavMeshCleaner.NativeFieldInfoPtr_m_MidLayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, "m_MidLayerCount");
			NavMeshCleaner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr, 100663556);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0007902C File Offset: 0x0007722C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72759, XrefRangeEnd = 72767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshCleaner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavMeshCleaner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshCleaner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000389F File Offset: 0x00001A9F
		public NavMeshCleaner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00079068 File Offset: 0x00077268
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000038A8 File Offset: 0x00001AA8
		public unsafe List<Vector3> m_WalkablePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_WalkablePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_WalkablePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00079098 File Offset: 0x00077298
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000038C7 File Offset: 0x00001AC7
		public unsafe float m_Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Height)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000790C0 File Offset: 0x000772C0
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x000038E2 File Offset: 0x00001AE2
		public unsafe float m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x000790E8 File Offset: 0x000772E8
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x000038FD File Offset: 0x00001AFD
		public unsafe int m_MidLayerCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_MidLayerCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavMeshCleaner.NativeFieldInfoPtr_m_MidLayerCount)) = value;
			}
		}

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_m_WalkablePoint;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_m_MidLayerCount;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
