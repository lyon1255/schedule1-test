using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005EF RID: 1519
	public class Accessory : MonoBehaviour
	{
		// Token: 0x0600849C RID: 33948 RVA: 0x002333D8 File Offset: 0x002315D8
		// Note: this type is marked as 'beforefieldinit'.
		static Accessory()
		{
			Il2CppClassPointerStore<Accessory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Accessory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Accessory>.NativeClassPtr);
			Accessory.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "Name");
			Accessory.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "AssetPath");
			Accessory.NativeFieldInfoPtr_ReduceFootSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ReduceFootSize");
			Accessory.NativeFieldInfoPtr_FootSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "FootSizeReduction");
			Accessory.NativeFieldInfoPtr_ShouldBlockHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ShouldBlockHair");
			Accessory.NativeFieldInfoPtr_ColorAllMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ColorAllMeshes");
			Accessory.NativeFieldInfoPtr_meshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "meshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToBind");
			Accessory.NativeFieldInfoPtr_shapeKeyMeshRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "shapeKeyMeshRends");
			Accessory.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679893);
			Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679894);
			Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679895);
			Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679896);
			Accessory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100679897);
		}

		// Token: 0x0600849D RID: 33949 RVA: 0x00233534 File Offset: 0x00231734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248854, XrefRangeEnd = 248856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600849E RID: 33950 RVA: 0x00233568 File Offset: 0x00231768
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 248866, RefRangeEnd = 248871, XrefRangeStart = 248856, XrefRangeEnd = 248866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600849F RID: 33951 RVA: 0x002335A8 File Offset: 0x002317A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248876, RefRangeEnd = 248878, XrefRangeStart = 248871, XrefRangeEnd = 248876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084A0 RID: 33952 RVA: 0x002335F4 File Offset: 0x002317F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248880, RefRangeEnd = 248881, XrefRangeStart = 248878, XrefRangeEnd = 248880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindBones(Il2CppReferenceArray<Transform> bones)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bones);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084A1 RID: 33953 RVA: 0x00233638 File Offset: 0x00231838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248882, RefRangeEnd = 248883, XrefRangeStart = 248881, XrefRangeEnd = 248882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Accessory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Accessory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x0003EDD6 File Offset: 0x0003CFD6
		public Accessory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x00233674 File Offset: 0x00231874
		// (set) Token: 0x060084A4 RID: 33956 RVA: 0x0003EDDF File Offset: 0x0003CFDF
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x0023369C File Offset: 0x0023189C
		// (set) Token: 0x060084A6 RID: 33958 RVA: 0x0003EDFE File Offset: 0x0003CFFE
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x060084A7 RID: 33959 RVA: 0x002336C4 File Offset: 0x002318C4
		// (set) Token: 0x060084A8 RID: 33960 RVA: 0x0003EE1D File Offset: 0x0003D01D
		public unsafe bool ReduceFootSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize)) = value;
			}
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x060084A9 RID: 33961 RVA: 0x002336EC File Offset: 0x002318EC
		// (set) Token: 0x060084AA RID: 33962 RVA: 0x0003EE38 File Offset: 0x0003D038
		public unsafe float FootSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction)) = value;
			}
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x060084AB RID: 33963 RVA: 0x00233714 File Offset: 0x00231914
		// (set) Token: 0x060084AC RID: 33964 RVA: 0x0003EE53 File Offset: 0x0003D053
		public unsafe bool ShouldBlockHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair)) = value;
			}
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x060084AD RID: 33965 RVA: 0x0023373C File Offset: 0x0023193C
		// (set) Token: 0x060084AE RID: 33966 RVA: 0x0003EE6E File Offset: 0x0003D06E
		public unsafe bool ColorAllMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes)) = value;
			}
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x060084AF RID: 33967 RVA: 0x00233764 File Offset: 0x00231964
		// (set) Token: 0x060084B0 RID: 33968 RVA: 0x0003EE89 File Offset: 0x0003D089
		public unsafe Il2CppReferenceArray<MeshRenderer> meshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x060084B1 RID: 33969 RVA: 0x00233794 File Offset: 0x00231994
		// (set) Token: 0x060084B2 RID: 33970 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x060084B3 RID: 33971 RVA: 0x002337C4 File Offset: 0x002319C4
		// (set) Token: 0x060084B4 RID: 33972 RVA: 0x0003EEC7 File Offset: 0x0003D0C7
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToBind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x060084B5 RID: 33973 RVA: 0x002337F4 File Offset: 0x002319F4
		// (set) Token: 0x060084B6 RID: 33974 RVA: 0x0003EEE6 File Offset: 0x0003D0E6
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> shapeKeyMeshRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005A4F RID: 23119
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005A50 RID: 23120
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005A51 RID: 23121
		private static readonly IntPtr NativeFieldInfoPtr_ReduceFootSize;

		// Token: 0x04005A52 RID: 23122
		private static readonly IntPtr NativeFieldInfoPtr_FootSizeReduction;

		// Token: 0x04005A53 RID: 23123
		private static readonly IntPtr NativeFieldInfoPtr_ShouldBlockHair;

		// Token: 0x04005A54 RID: 23124
		private static readonly IntPtr NativeFieldInfoPtr_ColorAllMeshes;

		// Token: 0x04005A55 RID: 23125
		private static readonly IntPtr NativeFieldInfoPtr_meshesToColor;

		// Token: 0x04005A56 RID: 23126
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToColor;

		// Token: 0x04005A57 RID: 23127
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToBind;

		// Token: 0x04005A58 RID: 23128
		private static readonly IntPtr NativeFieldInfoPtr_shapeKeyMeshRends;

		// Token: 0x04005A59 RID: 23129
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005A5A RID: 23130
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0;

		// Token: 0x04005A5B RID: 23131
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0;

		// Token: 0x04005A5C RID: 23132
		private static readonly IntPtr NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04005A5D RID: 23133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
