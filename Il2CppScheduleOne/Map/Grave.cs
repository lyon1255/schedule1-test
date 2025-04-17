using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200076F RID: 1903
	public class Grave : MonoBehaviour
	{
		// Token: 0x0600B49E RID: 46238 RVA: 0x002CF4C8 File Offset: 0x002CD6C8
		// Note: this type is marked as 'beforefieldinit'.
		static Grave()
		{
			Il2CppClassPointerStore<Grave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Grave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave>.NativeClassPtr);
			Grave.NativeFieldInfoPtr_Surfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "Surfaces");
			Grave.NativeFieldInfoPtr_HeadstoneObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneObjects");
			Grave.NativeFieldInfoPtr_HeadstoneMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMeshes");
			Grave.NativeFieldInfoPtr_HeadstoneMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMaterials");
			Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100685520);
			Grave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100685521);
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x002CF570 File Offset: 0x002CD770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309346, XrefRangeEnd = 309357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeGrave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x002CF5A4 File Offset: 0x002CD7A4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grave() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x0005899B File Offset: 0x00056B9B
		public Grave(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0600B4A2 RID: 46242 RVA: 0x002CF5E0 File Offset: 0x002CD7E0
		// (set) Token: 0x0600B4A3 RID: 46243 RVA: 0x000589A4 File Offset: 0x00056BA4
		public unsafe Il2CppReferenceArray<Grave.GraveSuface> Surfaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Grave.GraveSuface>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x002CF610 File Offset: 0x002CD810
		// (set) Token: 0x0600B4A5 RID: 46245 RVA: 0x000589C3 File Offset: 0x00056BC3
		public unsafe Il2CppReferenceArray<GameObject> HeadstoneObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0600B4A6 RID: 46246 RVA: 0x002CF640 File Offset: 0x002CD840
		// (set) Token: 0x0600B4A7 RID: 46247 RVA: 0x000589E2 File Offset: 0x00056BE2
		public unsafe Il2CppReferenceArray<MeshRenderer> HeadstoneMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600B4A8 RID: 46248 RVA: 0x002CF670 File Offset: 0x002CD870
		// (set) Token: 0x0600B4A9 RID: 46249 RVA: 0x00058A01 File Offset: 0x00056C01
		public unsafe Il2CppReferenceArray<Material> HeadstoneMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079BE RID: 31166
		private static readonly IntPtr NativeFieldInfoPtr_Surfaces;

		// Token: 0x040079BF RID: 31167
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneObjects;

		// Token: 0x040079C0 RID: 31168
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneMeshes;

		// Token: 0x040079C1 RID: 31169
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneMaterials;

		// Token: 0x040079C2 RID: 31170
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeGrave_Public_Void_0;

		// Token: 0x040079C3 RID: 31171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF8 RID: 3064
		[Serializable]
		public class GraveSuface : Il2CppSystem.Object
		{
			// Token: 0x0600DFA7 RID: 57255 RVA: 0x0034B068 File Offset: 0x00349268
			// Note: this type is marked as 'beforefieldinit'.
			static GraveSuface()
			{
				Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Grave>.NativeClassPtr, "GraveSuface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr);
				Grave.GraveSuface.NativeFieldInfoPtr_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Object");
				Grave.GraveSuface.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Mesh");
				Grave.GraveSuface.NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Materials");
				Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, 100685522);
			}

			// Token: 0x0600DFA8 RID: 57256 RVA: 0x0034B0E4 File Offset: 0x003492E4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GraveSuface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFA9 RID: 57257 RVA: 0x0006D0E5 File Offset: 0x0006B2E5
			public GraveSuface(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454E RID: 17742
			// (get) Token: 0x0600DFAA RID: 57258 RVA: 0x0034B120 File Offset: 0x00349320
			// (set) Token: 0x0600DFAB RID: 57259 RVA: 0x0006D0EE File Offset: 0x0006B2EE
			public unsafe GameObject Object
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454F RID: 17743
			// (get) Token: 0x0600DFAC RID: 57260 RVA: 0x0034B150 File Offset: 0x00349350
			// (set) Token: 0x0600DFAD RID: 57261 RVA: 0x0006D10D File Offset: 0x0006B30D
			public unsafe MeshRenderer Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004550 RID: 17744
			// (get) Token: 0x0600DFAE RID: 57262 RVA: 0x0034B180 File Offset: 0x00349380
			// (set) Token: 0x0600DFAF RID: 57263 RVA: 0x0006D12C File Offset: 0x0006B32C
			public unsafe Il2CppReferenceArray<Material> Materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095CD RID: 38349
			private static readonly IntPtr NativeFieldInfoPtr_Object;

			// Token: 0x040095CE RID: 38350
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x040095CF RID: 38351
			private static readonly IntPtr NativeFieldInfoPtr_Materials;

			// Token: 0x040095D0 RID: 38352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
