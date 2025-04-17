using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045A RID: 1114
	public class MapHeightSampler : Il2CppSystem.Object
	{
		// Token: 0x060060B5 RID: 24757 RVA: 0x001B9F10 File Offset: 0x001B8110
		// Note: this type is marked as 'beforefieldinit'.
		static MapHeightSampler()
		{
			Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "MapHeightSampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr);
			MapHeightSampler.NativeFieldInfoPtr_SampleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleHeight");
			MapHeightSampler.NativeFieldInfoPtr_SampleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleDistance");
			MapHeightSampler.NativeFieldInfoPtr_ResetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "ResetPosition");
			MapHeightSampler.NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, 100675599);
			MapHeightSampler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, 100675600);
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x001B9FA4 File Offset: 0x001B81A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199418, RefRangeEnd = 199421, XrefRangeStart = 199396, XrefRangeEnd = 199418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Sample(float x, out float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapHeightSampler.NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x001BA000 File Offset: 0x001B8200
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapHeightSampler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapHeightSampler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x0002DBBB File Offset: 0x0002BDBB
		public MapHeightSampler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x060060B9 RID: 24761 RVA: 0x001BA03C File Offset: 0x001B823C
		// (set) Token: 0x060060BA RID: 24762 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
		public unsafe static float SampleHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&value));
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x060060BB RID: 24763 RVA: 0x001BA058 File Offset: 0x001B8258
		// (set) Token: 0x060060BC RID: 24764 RVA: 0x0002DBD2 File Offset: 0x0002BDD2
		public unsafe static float SampleDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&value));
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x060060BD RID: 24765 RVA: 0x001BA074 File Offset: 0x001B8274
		// (set) Token: 0x060060BE RID: 24766 RVA: 0x0002DBE0 File Offset: 0x0002BDE0
		public unsafe static Vector3 ResetPosition
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_ResetPosition, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_ResetPosition, (void*)(&value));
			}
		}

		// Token: 0x04004201 RID: 16897
		private static readonly IntPtr NativeFieldInfoPtr_SampleHeight;

		// Token: 0x04004202 RID: 16898
		private static readonly IntPtr NativeFieldInfoPtr_SampleDistance;

		// Token: 0x04004203 RID: 16899
		private static readonly IntPtr NativeFieldInfoPtr_ResetPosition;

		// Token: 0x04004204 RID: 16900
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Public_Static_Boolean_Single_byref_Single_Single_0;

		// Token: 0x04004205 RID: 16901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
