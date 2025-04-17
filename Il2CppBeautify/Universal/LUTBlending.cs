using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppBeautify.Universal
{
	// Token: 0x0200013D RID: 317
	public class LUTBlending : MonoBehaviour
	{
		// Token: 0x06001A59 RID: 6745 RVA: 0x000C2E04 File Offset: 0x000C1004
		// Note: this type is marked as 'beforefieldinit'.
		static LUTBlending()
		{
			Il2CppClassPointerStore<LUTBlending>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Universal", "LUTBlending");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr);
			LUTBlending.NativeFieldInfoPtr_LUT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT1");
			LUTBlending.NativeFieldInfoPtr_LUT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT2");
			LUTBlending.NativeFieldInfoPtr_LUT1Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT1Intensity");
			LUTBlending.NativeFieldInfoPtr_LUT2Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "LUT2Intensity");
			LUTBlending.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "phase");
			LUTBlending.NativeFieldInfoPtr_lerpShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "lerpShader");
			LUTBlending.NativeFieldInfoPtr_oldPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "oldPhase");
			LUTBlending.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "rt");
			LUTBlending.NativeFieldInfoPtr_lerpMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "lerpMat");
			LUTBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666095);
			LUTBlending.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666096);
			LUTBlending.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666097);
			LUTBlending.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666098);
			LUTBlending.NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666099);
			LUTBlending.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, 100666100);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000C2F60 File Offset: 0x000C1160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97143, XrefRangeEnd = 97144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000C2F94 File Offset: 0x000C1194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97144, XrefRangeEnd = 97145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000C2FC8 File Offset: 0x000C11C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97145, XrefRangeEnd = 97150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000C2FFC File Offset: 0x000C11FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000C3030 File Offset: 0x000C1230
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97201, RefRangeEnd = 97204, XrefRangeStart = 97150, XrefRangeEnd = 97201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeautifyLUT()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000C3064 File Offset: 0x000C1264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97204, XrefRangeEnd = 97205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LUTBlending() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LUTBlending.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0000EEC6 File Offset: 0x0000D0C6
		public LUTBlending(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x000C30A0 File Offset: 0x000C12A0
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0000EECF File Offset: 0x0000D0CF
		public unsafe Texture2D LUT1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x000C30D0 File Offset: 0x000C12D0
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x0000EEEE File Offset: 0x0000D0EE
		public unsafe Texture2D LUT2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x000C3100 File Offset: 0x000C1300
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0000EF0D File Offset: 0x0000D10D
		public unsafe float LUT1Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT1Intensity)) = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x000C3128 File Offset: 0x000C1328
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000EF28 File Offset: 0x0000D128
		public unsafe float LUT2Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_LUT2Intensity)) = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000C3150 File Offset: 0x000C1350
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0000EF43 File Offset: 0x0000D143
		public unsafe float phase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_phase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_phase)) = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x000C3178 File Offset: 0x000C1378
		// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0000EF5E File Offset: 0x0000D15E
		public unsafe Shader lerpShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x000C31A8 File Offset: 0x000C13A8
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0000EF7D File Offset: 0x0000D17D
		public unsafe float oldPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_oldPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_oldPhase)) = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x000C31D0 File Offset: 0x000C13D0
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0000EF98 File Offset: 0x0000D198
		public unsafe RenderTexture rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x000C3200 File Offset: 0x000C1400
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x0000EFB7 File Offset: 0x0000D1B7
		public unsafe Material lerpMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LUTBlending.NativeFieldInfoPtr_lerpMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr_LUT1;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr_LUT2;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr_LUT1Intensity;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeFieldInfoPtr_LUT2Intensity;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr_phase;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeFieldInfoPtr_lerpShader;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeFieldInfoPtr_oldPhase;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeFieldInfoPtr_lerpMat;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeautifyLUT_Private_Void_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000858 RID: 2136
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600C05D RID: 49245 RVA: 0x002F0928 File Offset: 0x002EEB28
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LUTBlending>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr);
				LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr, "LUT2");
				LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LUTBlending.ShaderParams>.NativeClassPtr, "Phase");
			}

			// Token: 0x0600C05E RID: 49246 RVA: 0x0005DF87 File Offset: 0x0005C187
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE8 RID: 15336
			// (get) Token: 0x0600C05F RID: 49247 RVA: 0x002F097C File Offset: 0x002EEB7C
			// (set) Token: 0x0600C060 RID: 49248 RVA: 0x0005DF90 File Offset: 0x0005C190
			public unsafe static int LUT2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_LUT2, (void*)(&value));
				}
			}

			// Token: 0x17003BE9 RID: 15337
			// (get) Token: 0x0600C061 RID: 49249 RVA: 0x002F0998 File Offset: 0x002EEB98
			// (set) Token: 0x0600C062 RID: 49250 RVA: 0x0005DF9E File Offset: 0x0005C19E
			public unsafe static int Phase
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LUTBlending.ShaderParams.NativeFieldInfoPtr_Phase, (void*)(&value));
				}
			}

			// Token: 0x0400825A RID: 33370
			private static readonly IntPtr NativeFieldInfoPtr_LUT2;

			// Token: 0x0400825B RID: 33371
			private static readonly IntPtr NativeFieldInfoPtr_Phase;
		}
	}
}
