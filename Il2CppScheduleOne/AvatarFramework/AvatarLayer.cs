using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F2 RID: 1522
	[Serializable]
	public class AvatarLayer : ScriptableObject
	{
		// Token: 0x060085AF RID: 34223 RVA: 0x00236A98 File Offset: 0x00234C98
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLayer()
		{
			Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr);
			AvatarLayer.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Name");
			AvatarLayer.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "AssetPath");
			AvatarLayer.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Texture");
			AvatarLayer.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal");
			AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal_DefaultFormat");
			AvatarLayer.NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Order");
			AvatarLayer.NativeFieldInfoPtr_CombinedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "CombinedMaterial");
			AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, 100680001);
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x00236B68 File Offset: 0x00234D68
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x0003F813 File Offset: 0x0003DA13
		public AvatarLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x060085B2 RID: 34226 RVA: 0x00236BA4 File Offset: 0x00234DA4
		// (set) Token: 0x060085B3 RID: 34227 RVA: 0x0003F81C File Offset: 0x0003DA1C
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x060085B4 RID: 34228 RVA: 0x00236BCC File Offset: 0x00234DCC
		// (set) Token: 0x060085B5 RID: 34229 RVA: 0x0003F83B File Offset: 0x0003DA3B
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x060085B6 RID: 34230 RVA: 0x00236BF4 File Offset: 0x00234DF4
		// (set) Token: 0x060085B7 RID: 34231 RVA: 0x0003F85A File Offset: 0x0003DA5A
		public unsafe Texture2D Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x060085B8 RID: 34232 RVA: 0x00236C24 File Offset: 0x00234E24
		// (set) Token: 0x060085B9 RID: 34233 RVA: 0x0003F879 File Offset: 0x0003DA79
		public unsafe Texture2D Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x060085BA RID: 34234 RVA: 0x00236C54 File Offset: 0x00234E54
		// (set) Token: 0x060085BB RID: 34235 RVA: 0x0003F898 File Offset: 0x0003DA98
		public unsafe Texture2D Normal_DefaultFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x060085BC RID: 34236 RVA: 0x00236C84 File Offset: 0x00234E84
		// (set) Token: 0x060085BD RID: 34237 RVA: 0x0003F8B7 File Offset: 0x0003DAB7
		public unsafe int Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order)) = value;
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x060085BE RID: 34238 RVA: 0x00236CAC File Offset: 0x00234EAC
		// (set) Token: 0x060085BF RID: 34239 RVA: 0x0003F8D2 File Offset: 0x0003DAD2
		public unsafe Material CombinedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B03 RID: 23299
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005B04 RID: 23300
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005B05 RID: 23301
		private static readonly IntPtr NativeFieldInfoPtr_Texture;

		// Token: 0x04005B06 RID: 23302
		private static readonly IntPtr NativeFieldInfoPtr_Normal;

		// Token: 0x04005B07 RID: 23303
		private static readonly IntPtr NativeFieldInfoPtr_Normal_DefaultFormat;

		// Token: 0x04005B08 RID: 23304
		private static readonly IntPtr NativeFieldInfoPtr_Order;

		// Token: 0x04005B09 RID: 23305
		private static readonly IntPtr NativeFieldInfoPtr_CombinedMaterial;

		// Token: 0x04005B0A RID: 23306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
