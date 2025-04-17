using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppArdenfall.Utilities
{
	// Token: 0x02000164 RID: 356
	public class BillboardAsset : ScriptableObject
	{
		// Token: 0x06001CBF RID: 7359 RVA: 0x000C9B80 File Offset: 0x000C7D80
		// Note: this type is marked as 'beforefieldinit'.
		static BillboardAsset()
		{
			Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ardenfall.Utilities", "BillboardAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr);
			BillboardAsset.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "prefab");
			BillboardAsset.NativeFieldInfoPtr_renderSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "renderSettings");
			BillboardAsset.NativeFieldInfoPtr_textureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "textureSize");
			BillboardAsset.NativeFieldInfoPtr_cutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "cutoff");
			BillboardAsset.NativeFieldInfoPtr_pickLastLOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "pickLastLOD");
			BillboardAsset.NativeFieldInfoPtr_LODIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "LODIndex");
			BillboardAsset.NativeFieldInfoPtr_generatedTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedTextures");
			BillboardAsset.NativeFieldInfoPtr_generatedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedMesh");
			BillboardAsset.NativeFieldInfoPtr_generatedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedMaterial");
			BillboardAsset.NativeFieldInfoPtr_generatedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, "generatedPrefab");
			BillboardAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr, 100666310);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000C9C8C File Offset: 0x000C7E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101309, XrefRangeEnd = 101310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BillboardAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillboardAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000105B9 File Offset: 0x0000E7B9
		public BillboardAsset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000C9CC8 File Offset: 0x000C7EC8
		// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x000105C2 File Offset: 0x0000E7C2
		public unsafe GameObject prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000C9CF8 File Offset: 0x000C7EF8
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x000105E1 File Offset: 0x0000E7E1
		public unsafe BillboardRenderSettings renderSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_renderSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BillboardRenderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_renderSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x000C9D28 File Offset: 0x000C7F28
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00010600 File Offset: 0x0000E800
		public unsafe int textureSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_textureSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_textureSize)) = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000C9D50 File Offset: 0x000C7F50
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0001061B File Offset: 0x0000E81B
		public unsafe float cutoff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_cutoff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_cutoff)) = value;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x000C9D78 File Offset: 0x000C7F78
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00010636 File Offset: 0x0000E836
		public unsafe bool pickLastLOD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_pickLastLOD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_pickLastLOD)) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000C9DA0 File Offset: 0x000C7FA0
		// (set) Token: 0x06001CCD RID: 7373 RVA: 0x00010651 File Offset: 0x0000E851
		public unsafe int LODIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_LODIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_LODIndex)) = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x000C9DC8 File Offset: 0x000C7FC8
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0001066C File Offset: 0x0000E86C
		public unsafe List<Texture2D> generatedTextures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedTextures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedTextures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000C9DF8 File Offset: 0x000C7FF8
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0001068B File Offset: 0x0000E88B
		public unsafe Mesh generatedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000C9E28 File Offset: 0x000C8028
		// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x000106AA File Offset: 0x0000E8AA
		public unsafe Material generatedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x000C9E58 File Offset: 0x000C8058
		// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000106C9 File Offset: 0x0000E8C9
		public unsafe GameObject generatedPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillboardAsset.NativeFieldInfoPtr_generatedPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_prefab;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_renderSettings;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_textureSize;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_cutoff;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_pickLastLOD;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_LODIndex;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_generatedTextures;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_generatedMesh;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_generatedMaterial;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr_generatedPrefab;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
