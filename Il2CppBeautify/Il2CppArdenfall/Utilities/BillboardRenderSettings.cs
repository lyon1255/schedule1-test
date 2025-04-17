using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppArdenfall.Utilities
{
	// Token: 0x02000165 RID: 357
	public class BillboardRenderSettings : ScriptableObject
	{
		// Token: 0x06001CD6 RID: 7382 RVA: 0x000C9E88 File Offset: 0x000C8088
		// Note: this type is marked as 'beforefieldinit'.
		static BillboardRenderSettings()
		{
			Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ardenfall.Utilities", "BillboardRenderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr);
			BillboardRenderSettings.NativeFieldInfoPtr_billboardTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "billboardTextures");
			BillboardRenderSettings.NativeFieldInfoPtr_billboardShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "billboardShader");
			BillboardRenderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, 100666311);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000C9EF4 File Offset: 0x000C80F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BillboardRenderSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000106E8 File Offset: 0x0000E8E8
		public BillboardRenderSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x000C9F30 File Offset: 0x000C8130
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x000106F1 File Offset: 0x0000E8F1
		public unsafe List<BillboardRenderSettings.BillboardTexture> billboardTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BillboardRenderSettings.BillboardTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x000C9F60 File Offset: 0x000C8160
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x00010710 File Offset: 0x0000E910
		public unsafe Shader billboardShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.NativeFieldInfoPtr_billboardShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr_billboardTextures;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr_billboardShader;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000868 RID: 2152
		[Serializable]
		public class BillboardTexture : Il2CppSystem.Object
		{
			// Token: 0x0600C118 RID: 49432 RVA: 0x002F2774 File Offset: 0x002F0974
			// Note: this type is marked as 'beforefieldinit'.
			static BillboardTexture()
			{
				Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "BillboardTexture");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr);
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_textureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "textureId");
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_powerOfTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "powerOfTwo");
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_alphaIsTransparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "alphaIsTransparency");
				BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_bakePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, "bakePasses");
				BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr_GetFormat_Public_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, 100666312);
				BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr, 100666313);
			}

			// Token: 0x0600C119 RID: 49433 RVA: 0x002F2818 File Offset: 0x002F0A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101310, XrefRangeEnd = 101330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureFormat GetFormat()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr_GetFormat_Public_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C11A RID: 49434 RVA: 0x002F2854 File Offset: 0x002F0A54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101330, XrefRangeEnd = 101335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BillboardTexture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardRenderSettings.BillboardTexture>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.BillboardTexture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C11B RID: 49435 RVA: 0x0005E676 File Offset: 0x0005C876
			public BillboardTexture(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C2B RID: 15403
			// (get) Token: 0x0600C11C RID: 49436 RVA: 0x002F2890 File Offset: 0x002F0A90
			// (set) Token: 0x0600C11D RID: 49437 RVA: 0x0005E67F File Offset: 0x0005C87F
			public unsafe string textureId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_textureId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_textureId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C2C RID: 15404
			// (get) Token: 0x0600C11E RID: 49438 RVA: 0x002F28B8 File Offset: 0x002F0AB8
			// (set) Token: 0x0600C11F RID: 49439 RVA: 0x0005E69E File Offset: 0x0005C89E
			public unsafe bool powerOfTwo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_powerOfTwo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_powerOfTwo)) = value;
				}
			}

			// Token: 0x17003C2D RID: 15405
			// (get) Token: 0x0600C120 RID: 49440 RVA: 0x002F28E0 File Offset: 0x002F0AE0
			// (set) Token: 0x0600C121 RID: 49441 RVA: 0x0005E6B9 File Offset: 0x0005C8B9
			public unsafe bool alphaIsTransparency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_alphaIsTransparency);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_alphaIsTransparency)) = value;
				}
			}

			// Token: 0x17003C2E RID: 15406
			// (get) Token: 0x0600C122 RID: 49442 RVA: 0x002F2908 File Offset: 0x002F0B08
			// (set) Token: 0x0600C123 RID: 49443 RVA: 0x0005E6D4 File Offset: 0x0005C8D4
			public unsafe List<BillboardRenderSettings.BakePass> bakePasses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_bakePasses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BillboardRenderSettings.BakePass>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BillboardTexture.NativeFieldInfoPtr_bakePasses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082CA RID: 33482
			private static readonly IntPtr NativeFieldInfoPtr_textureId;

			// Token: 0x040082CB RID: 33483
			private static readonly IntPtr NativeFieldInfoPtr_powerOfTwo;

			// Token: 0x040082CC RID: 33484
			private static readonly IntPtr NativeFieldInfoPtr_alphaIsTransparency;

			// Token: 0x040082CD RID: 33485
			private static readonly IntPtr NativeFieldInfoPtr_bakePasses;

			// Token: 0x040082CE RID: 33486
			private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_TextureFormat_0;

			// Token: 0x040082CF RID: 33487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000869 RID: 2153
		[Serializable]
		public class BakePass : Il2CppSystem.Object
		{
			// Token: 0x0600C124 RID: 49444 RVA: 0x002F2938 File Offset: 0x002F0B38
			// Note: this type is marked as 'beforefieldinit'.
			static BakePass()
			{
				Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BillboardRenderSettings>.NativeClassPtr, "BakePass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr);
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_customShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "customShader");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_materialOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "materialOverrides");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "r");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "g");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "b");
				BillboardRenderSettings.BakePass.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, "a");
				BillboardRenderSettings.BakePass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr, 100666314);
			}

			// Token: 0x0600C125 RID: 49445 RVA: 0x002F29F0 File Offset: 0x002F0BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101335, XrefRangeEnd = 101336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BakePass() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardRenderSettings.BakePass>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardRenderSettings.BakePass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C126 RID: 49446 RVA: 0x0005E6F3 File Offset: 0x0005C8F3
			public BakePass(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C2F RID: 15407
			// (get) Token: 0x0600C127 RID: 49447 RVA: 0x002F2A2C File Offset: 0x002F0C2C
			// (set) Token: 0x0600C128 RID: 49448 RVA: 0x0005E6FC File Offset: 0x0005C8FC
			public unsafe Shader customShader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_customShader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_customShader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C30 RID: 15408
			// (get) Token: 0x0600C129 RID: 49449 RVA: 0x002F2A5C File Offset: 0x002F0C5C
			// (set) Token: 0x0600C12A RID: 49450 RVA: 0x0005E71B File Offset: 0x0005C91B
			public unsafe MaterialOverrides materialOverrides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_materialOverrides);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialOverrides>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_materialOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C31 RID: 15409
			// (get) Token: 0x0600C12B RID: 49451 RVA: 0x002F2A8C File Offset: 0x002F0C8C
			// (set) Token: 0x0600C12C RID: 49452 RVA: 0x0005E73A File Offset: 0x0005C93A
			public unsafe bool r
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_r);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_r)) = value;
				}
			}

			// Token: 0x17003C32 RID: 15410
			// (get) Token: 0x0600C12D RID: 49453 RVA: 0x002F2AB4 File Offset: 0x002F0CB4
			// (set) Token: 0x0600C12E RID: 49454 RVA: 0x0005E755 File Offset: 0x0005C955
			public unsafe bool g
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_g);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_g)) = value;
				}
			}

			// Token: 0x17003C33 RID: 15411
			// (get) Token: 0x0600C12F RID: 49455 RVA: 0x002F2ADC File Offset: 0x002F0CDC
			// (set) Token: 0x0600C130 RID: 49456 RVA: 0x0005E770 File Offset: 0x0005C970
			public unsafe bool b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_b);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_b)) = value;
				}
			}

			// Token: 0x17003C34 RID: 15412
			// (get) Token: 0x0600C131 RID: 49457 RVA: 0x002F2B04 File Offset: 0x002F0D04
			// (set) Token: 0x0600C132 RID: 49458 RVA: 0x0005E78B File Offset: 0x0005C98B
			public unsafe bool a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_a);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardRenderSettings.BakePass.NativeFieldInfoPtr_a)) = value;
				}
			}

			// Token: 0x040082D0 RID: 33488
			private static readonly IntPtr NativeFieldInfoPtr_customShader;

			// Token: 0x040082D1 RID: 33489
			private static readonly IntPtr NativeFieldInfoPtr_materialOverrides;

			// Token: 0x040082D2 RID: 33490
			private static readonly IntPtr NativeFieldInfoPtr_r;

			// Token: 0x040082D3 RID: 33491
			private static readonly IntPtr NativeFieldInfoPtr_g;

			// Token: 0x040082D4 RID: 33492
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x040082D5 RID: 33493
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x040082D6 RID: 33494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
