using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000129 RID: 297
	public class LightningSpawnArea : MonoBehaviour
	{
		// Token: 0x06001966 RID: 6502 RVA: 0x000BFF38 File Offset: 0x000BE138
		// Note: this type is marked as 'beforefieldinit'.
		static LightningSpawnArea()
		{
			Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningSpawnArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr);
			LightningSpawnArea.NativeFieldInfoPtr_lightningArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, "lightningArea");
			LightningSpawnArea.NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666004);
			LightningSpawnArea.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666005);
			LightningSpawnArea.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666006);
			LightningSpawnArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr, 100666007);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x000BFFCC File Offset: 0x000BE1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96217, XrefRangeEnd = 96232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000C0000 File Offset: 0x000BE200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96232, XrefRangeEnd = 96248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000C0034 File Offset: 0x000BE234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96248, XrefRangeEnd = 96264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000C0068 File Offset: 0x000BE268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96264, XrefRangeEnd = 96265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningSpawnArea() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningSpawnArea>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningSpawnArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0000E780 File Offset: 0x0000C980
		public LightningSpawnArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x000C00A4 File Offset: 0x000BE2A4
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000E789 File Offset: 0x0000C989
		public unsafe Vector3 lightningArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningSpawnArea.NativeFieldInfoPtr_lightningArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningSpawnArea.NativeFieldInfoPtr_lightningArea)) = value;
			}
		}

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeFieldInfoPtr_lightningArea;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Public_Void_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
