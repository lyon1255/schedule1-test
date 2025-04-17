using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000470 RID: 1136
	[Serializable]
	[StructLayout(2)]
	public struct DisplaySettings
	{
		// Token: 0x0600624E RID: 25166 RVA: 0x001BF1FC File Offset: 0x001BD3FC
		// Note: this type is marked as 'beforefieldinit'.
		static DisplaySettings()
		{
			Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "DisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr);
			DisplaySettings.NativeFieldInfoPtr_ResolutionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ResolutionIndex");
			DisplaySettings.NativeFieldInfoPtr_DisplayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "DisplayMode");
			DisplaySettings.NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "VSync");
			DisplaySettings.NativeFieldInfoPtr_TargetFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "TargetFPS");
			DisplaySettings.NativeFieldInfoPtr_UIScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "UIScale");
			DisplaySettings.NativeFieldInfoPtr_CameraBobbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "CameraBobbing");
			DisplaySettings.NativeFieldInfoPtr_ActiveDisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ActiveDisplayIndex");
			DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, 100675766);
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x001BF2CC File Offset: 0x001BD4CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201896, RefRangeEnd = 201898, XrefRangeStart = 201866, XrefRangeEnd = 201896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Resolution> GetResolutions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Resolution>>(intPtr3) : null;
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x0002E76E File Offset: 0x0002C96E
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04004303 RID: 17155
		private static readonly IntPtr NativeFieldInfoPtr_ResolutionIndex;

		// Token: 0x04004304 RID: 17156
		private static readonly IntPtr NativeFieldInfoPtr_DisplayMode;

		// Token: 0x04004305 RID: 17157
		private static readonly IntPtr NativeFieldInfoPtr_VSync;

		// Token: 0x04004306 RID: 17158
		private static readonly IntPtr NativeFieldInfoPtr_TargetFPS;

		// Token: 0x04004307 RID: 17159
		private static readonly IntPtr NativeFieldInfoPtr_UIScale;

		// Token: 0x04004308 RID: 17160
		private static readonly IntPtr NativeFieldInfoPtr_CameraBobbing;

		// Token: 0x04004309 RID: 17161
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDisplayIndex;

		// Token: 0x0400430A RID: 17162
		private static readonly IntPtr NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0;

		// Token: 0x0400430B RID: 17163
		[FieldOffset(0)]
		public int ResolutionIndex;

		// Token: 0x0400430C RID: 17164
		[FieldOffset(4)]
		public DisplaySettings.EDisplayMode DisplayMode;

		// Token: 0x0400430D RID: 17165
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool VSync;

		// Token: 0x0400430E RID: 17166
		[FieldOffset(12)]
		public int TargetFPS;

		// Token: 0x0400430F RID: 17167
		[FieldOffset(16)]
		public float UIScale;

		// Token: 0x04004310 RID: 17168
		[FieldOffset(20)]
		public float CameraBobbing;

		// Token: 0x04004311 RID: 17169
		[FieldOffset(24)]
		public int ActiveDisplayIndex;

		// Token: 0x02000A1B RID: 2587
		[OriginalName("Assembly-CSharp.dll", "", "EDisplayMode")]
		public enum EDisplayMode
		{
			// Token: 0x04008B9E RID: 35742
			Windowed,
			// Token: 0x04008B9F RID: 35743
			FullscreenWindow,
			// Token: 0x04008BA0 RID: 35744
			ExclusiveFullscreen
		}

		// Token: 0x02000A1C RID: 2588
		[ObfuscatedName("ScheduleOne.DevUtilities.DisplaySettings+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEF9 RID: 52985 RVA: 0x0031BF2C File Offset: 0x0031A12C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr);
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "resolutions");
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "i");
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "<>9__0");
				DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, 100675767);
				DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, 100675768);
			}

			// Token: 0x0600CEFA RID: 52986 RVA: 0x0031BFBC File Offset: 0x0031A1BC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEFB RID: 52987 RVA: 0x0031BFF8 File Offset: 0x0031A1F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201864, XrefRangeEnd = 201866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResolutions_b__0(Resolution x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEFC RID: 52988 RVA: 0x00064AAD File Offset: 0x00062CAD
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405C RID: 16476
			// (get) Token: 0x0600CEFD RID: 52989 RVA: 0x0031C044 File Offset: 0x0031A244
			// (set) Token: 0x0600CEFE RID: 52990 RVA: 0x00064AB6 File Offset: 0x00062CB6
			public unsafe Il2CppStructArray<Resolution> resolutions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700405D RID: 16477
			// (get) Token: 0x0600CEFF RID: 52991 RVA: 0x0031C074 File Offset: 0x0031A274
			// (set) Token: 0x0600CF00 RID: 52992 RVA: 0x00064AD5 File Offset: 0x00062CD5
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700405E RID: 16478
			// (get) Token: 0x0600CF01 RID: 52993 RVA: 0x0031C09C File Offset: 0x0031A29C
			// (set) Token: 0x0600CF02 RID: 52994 RVA: 0x00064AF0 File Offset: 0x00062CF0
			public unsafe Predicate<Resolution> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Resolution>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BA1 RID: 35745
			private static readonly IntPtr NativeFieldInfoPtr_resolutions;

			// Token: 0x04008BA2 RID: 35746
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008BA3 RID: 35747
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008BA4 RID: 35748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BA5 RID: 35749
			private static readonly IntPtr NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0;
		}
	}
}
