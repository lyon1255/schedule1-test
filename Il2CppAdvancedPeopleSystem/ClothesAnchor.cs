using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000144 RID: 324
	[Serializable]
	public class ClothesAnchor : Il2CppSystem.Object
	{
		// Token: 0x06001B0F RID: 6927 RVA: 0x000C5530 File Offset: 0x000C3730
		// Note: this type is marked as 'beforefieldinit'.
		static ClothesAnchor()
		{
			Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "ClothesAnchor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr);
			ClothesAnchor.NativeFieldInfoPtr_partType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr, "partType");
			ClothesAnchor.NativeFieldInfoPtr_skinnedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr, "skinnedMesh");
			ClothesAnchor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr, 100666197);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x000C559C File Offset: 0x000C379C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99595, RefRangeEnd = 99596, XrefRangeStart = 99587, XrefRangeEnd = 99595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothesAnchor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothesAnchor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothesAnchor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0000F447 File Offset: 0x0000D647
		public ClothesAnchor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x000C55D8 File Offset: 0x000C37D8
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0000F450 File Offset: 0x0000D650
		public unsafe CharacterElementType partType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_partType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_partType)) = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x000C5600 File Offset: 0x000C3800
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0000F46B File Offset: 0x0000D66B
		public unsafe List<SkinnedMeshRenderer> skinnedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_skinnedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothesAnchor.NativeFieldInfoPtr_skinnedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_partType;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMesh;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
