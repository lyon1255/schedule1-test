using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000055 RID: 85
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		// Token: 0x060006A0 RID: 1696 RVA: 0x00084560 File Offset: 0x00082760
		// Note: this type is marked as 'beforefieldinit'.
		static DitheringComponent()
		{
			Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DitheringComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr);
			DitheringComponent.NativeFieldInfoPtr_noiseTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "noiseTextures");
			DitheringComponent.NativeFieldInfoPtr_textureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "textureIndex");
			DitheringComponent.NativeFieldInfoPtr_k_TextureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "k_TextureCount");
			DitheringComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663948);
			DitheringComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663949);
			DitheringComponent.NativeMethodInfoPtr_LoadNoiseTextures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663950);
			DitheringComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663951);
			DitheringComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, 100663952);
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00084630 File Offset: 0x00082830
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76624, XrefRangeEnd = 76625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0008466C File Offset: 0x0008286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76625, XrefRangeEnd = 76626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000846A0 File Offset: 0x000828A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76626, XrefRangeEnd = 76638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNoiseTextures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_LoadNoiseTextures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000846D4 File Offset: 0x000828D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76638, XrefRangeEnd = 76664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00084718 File Offset: 0x00082918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76667, RefRangeEnd = 76668, XrefRangeStart = 76664, XrefRangeEnd = 76667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DitheringComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DitheringComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00005C4E File Offset: 0x00003E4E
		public DitheringComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00084754 File Offset: 0x00082954
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00005C57 File Offset: 0x00003E57
		public unsafe Il2CppReferenceArray<Texture2D> noiseTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_noiseTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_noiseTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00084784 File Offset: 0x00082984
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00005C76 File Offset: 0x00003E76
		public unsafe int textureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_textureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DitheringComponent.NativeFieldInfoPtr_textureIndex)) = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x000847AC File Offset: 0x000829AC
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00005C91 File Offset: 0x00003E91
		public unsafe static int k_TextureCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DitheringComponent.NativeFieldInfoPtr_k_TextureCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DitheringComponent.NativeFieldInfoPtr_k_TextureCount, (void*)(&value));
			}
		}

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_noiseTextures;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_textureIndex;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_k_TextureCount;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_LoadNoiseTextures_Private_Void_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CC RID: 1996
		public static class Uniforms : Object
		{
			// Token: 0x0600BB58 RID: 47960 RVA: 0x002E54E4 File Offset: 0x002E36E4
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DitheringComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr);
				DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr, "_DitheringTex");
				DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DitheringComponent.Uniforms>.NativeClassPtr, "_DitheringCoords");
			}

			// Token: 0x0600BB59 RID: 47961 RVA: 0x0005BA9D File Offset: 0x00059C9D
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039F1 RID: 14833
			// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x002E5538 File Offset: 0x002E3738
			// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x0005BAA6 File Offset: 0x00059CA6
			public unsafe static int _DitheringTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringTex, (void*)(&value));
				}
			}

			// Token: 0x170039F2 RID: 14834
			// (get) Token: 0x0600BB5C RID: 47964 RVA: 0x002E5554 File Offset: 0x002E3754
			// (set) Token: 0x0600BB5D RID: 47965 RVA: 0x0005BAB4 File Offset: 0x00059CB4
			public unsafe static int _DitheringCoords
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringCoords, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DitheringComponent.Uniforms.NativeFieldInfoPtr__DitheringCoords, (void*)(&value));
				}
			}

			// Token: 0x04007E45 RID: 32325
			private static readonly IntPtr NativeFieldInfoPtr__DitheringTex;

			// Token: 0x04007E46 RID: 32326
			private static readonly IntPtr NativeFieldInfoPtr__DitheringCoords;
		}
	}
}
