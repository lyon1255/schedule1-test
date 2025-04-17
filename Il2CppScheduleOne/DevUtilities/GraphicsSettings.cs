using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000472 RID: 1138
	[Serializable]
	public class GraphicsSettings : Object
	{
		// Token: 0x06006256 RID: 25174 RVA: 0x001BF3BC File Offset: 0x001BD5BC
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GraphicsQuality");
			GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "AntiAliasingMode");
			GraphicsSettings.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "FOV");
			GraphicsSettings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "SSAO");
			GraphicsSettings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GodRays");
			GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100675770);
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x001BF464 File Offset: 0x001BD664
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x0002E7A4 File Offset: 0x0002C9A4
		public GraphicsSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06006259 RID: 25177 RVA: 0x001BF4A0 File Offset: 0x001BD6A0
		// (set) Token: 0x0600625A RID: 25178 RVA: 0x0002E7AD File Offset: 0x0002C9AD
		public unsafe GraphicsSettings.EGraphicsQuality GraphicsQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality)) = value;
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x0600625B RID: 25179 RVA: 0x001BF4C8 File Offset: 0x001BD6C8
		// (set) Token: 0x0600625C RID: 25180 RVA: 0x0002E7C8 File Offset: 0x0002C9C8
		public unsafe GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode)) = value;
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x0600625D RID: 25181 RVA: 0x001BF4F0 File Offset: 0x001BD6F0
		// (set) Token: 0x0600625E RID: 25182 RVA: 0x0002E7E3 File Offset: 0x0002C9E3
		public unsafe float FOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x0600625F RID: 25183 RVA: 0x001BF518 File Offset: 0x001BD718
		// (set) Token: 0x06006260 RID: 25184 RVA: 0x0002E7FE File Offset: 0x0002C9FE
		public unsafe bool SSAO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO)) = value;
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06006261 RID: 25185 RVA: 0x001BF540 File Offset: 0x001BD740
		// (set) Token: 0x06006262 RID: 25186 RVA: 0x0002E819 File Offset: 0x0002CA19
		public unsafe bool GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays)) = value;
			}
		}

		// Token: 0x04004314 RID: 17172
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsQuality;

		// Token: 0x04004315 RID: 17173
		private static readonly IntPtr NativeFieldInfoPtr_AntiAliasingMode;

		// Token: 0x04004316 RID: 17174
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04004317 RID: 17175
		private static readonly IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x04004318 RID: 17176
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04004319 RID: 17177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A1D RID: 2589
		[OriginalName("Assembly-CSharp.dll", "", "EAntiAliasingMode")]
		public enum EAntiAliasingMode
		{
			// Token: 0x04008BA7 RID: 35751
			Off,
			// Token: 0x04008BA8 RID: 35752
			FXAA,
			// Token: 0x04008BA9 RID: 35753
			SMAA
		}

		// Token: 0x02000A1E RID: 2590
		[OriginalName("Assembly-CSharp.dll", "", "EGraphicsQuality")]
		public enum EGraphicsQuality
		{
			// Token: 0x04008BAB RID: 35755
			Low,
			// Token: 0x04008BAC RID: 35756
			Medium,
			// Token: 0x04008BAD RID: 35757
			High,
			// Token: 0x04008BAE RID: 35758
			Ultra
		}
	}
}
