using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200012E RID: 302
	public class WeatherDepthCamera : MonoBehaviour
	{
		// Token: 0x060019BE RID: 6590 RVA: 0x000C1000 File Offset: 0x000BF200
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherDepthCamera()
		{
			Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "WeatherDepthCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr);
			WeatherDepthCamera.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "m_DepthCamera");
			WeatherDepthCamera.NativeFieldInfoPtr_depthShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "depthShader");
			WeatherDepthCamera.NativeFieldInfoPtr_overheadDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "overheadDepthTexture");
			WeatherDepthCamera.NativeFieldInfoPtr_renderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "renderFrameInterval");
			WeatherDepthCamera.NativeFieldInfoPtr_textureResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, "textureResolution");
			WeatherDepthCamera.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666032);
			WeatherDepthCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666033);
			WeatherDepthCamera.NativeMethodInfoPtr_RenderOverheadCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666034);
			WeatherDepthCamera.NativeMethodInfoPtr_PrepareRenderTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666035);
			WeatherDepthCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr, 100666036);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000C10F8 File Offset: 0x000BF2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96642, XrefRangeEnd = 96648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000C112C File Offset: 0x000BF32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96648, XrefRangeEnd = 96652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000C1160 File Offset: 0x000BF360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96687, RefRangeEnd = 96688, XrefRangeStart = 96652, XrefRangeEnd = 96687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderOverheadCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_RenderOverheadCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000C1194 File Offset: 0x000BF394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96713, RefRangeEnd = 96714, XrefRangeStart = 96688, XrefRangeEnd = 96713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareRenderTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr_PrepareRenderTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000C11C8 File Offset: 0x000BF3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96714, XrefRangeEnd = 96715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherDepthCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherDepthCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherDepthCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public WeatherDepthCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x000C1204 File Offset: 0x000BF404
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x0000EA8D File Offset: 0x0000CC8D
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000C1234 File Offset: 0x000BF434
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x0000EAAC File Offset: 0x0000CCAC
		public unsafe Shader depthShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_depthShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_depthShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x000C1264 File Offset: 0x000BF464
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x0000EACB File Offset: 0x0000CCCB
		public unsafe RenderTexture overheadDepthTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_overheadDepthTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_overheadDepthTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x000C1294 File Offset: 0x000BF494
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x0000EAEA File Offset: 0x0000CCEA
		public unsafe int renderFrameInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_renderFrameInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_renderFrameInterval)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x000C12BC File Offset: 0x000BF4BC
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x0000EB05 File Offset: 0x0000CD05
		public unsafe int textureResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_textureResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherDepthCamera.NativeFieldInfoPtr_textureResolution)) = value;
			}
		}

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_depthShader;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeFieldInfoPtr_overheadDepthTexture;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeFieldInfoPtr_renderFrameInterval;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr_textureResolution;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_RenderOverheadCamera_Private_Void_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRenderTexture_Private_Void_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
