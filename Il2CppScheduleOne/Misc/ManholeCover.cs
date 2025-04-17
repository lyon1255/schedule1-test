using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000768 RID: 1896
	public class ManholeCover : MonoBehaviour
	{
		// Token: 0x0600B400 RID: 46080 RVA: 0x002CD894 File Offset: 0x002CBA94
		// Note: this type is marked as 'beforefieldinit'.
		static ManholeCover()
		{
			Il2CppClassPointerStore<ManholeCover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ManholeCover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr);
			ManholeCover.NativeFieldInfoPtr_SteamParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamParticles");
			ManholeCover.NativeFieldInfoPtr_SteamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamColor");
			ManholeCover.NativeFieldInfoPtr_SteamAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamAlpha");
			ManholeCover.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100685470);
			ManholeCover.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100685471);
			ManholeCover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100685472);
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x002CD93C File Offset: 0x002CBB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308766, XrefRangeEnd = 308784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B402 RID: 46082 RVA: 0x002CD970 File Offset: 0x002CBB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308784, XrefRangeEnd = 308794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B403 RID: 46083 RVA: 0x002CD9A4 File Offset: 0x002CBBA4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManholeCover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B404 RID: 46084 RVA: 0x000583DF File Offset: 0x000565DF
		public ManholeCover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600B405 RID: 46085 RVA: 0x002CD9E0 File Offset: 0x002CBBE0
		// (set) Token: 0x0600B406 RID: 46086 RVA: 0x000583E8 File Offset: 0x000565E8
		public unsafe ParticleSystem SteamParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600B407 RID: 46087 RVA: 0x002CDA10 File Offset: 0x002CBC10
		// (set) Token: 0x0600B408 RID: 46088 RVA: 0x00058407 File Offset: 0x00056607
		public unsafe Gradient SteamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600B409 RID: 46089 RVA: 0x002CDA40 File Offset: 0x002CBC40
		// (set) Token: 0x0600B40A RID: 46090 RVA: 0x00058426 File Offset: 0x00056626
		public unsafe AnimationCurve SteamAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamAlpha);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamAlpha), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400795F RID: 31071
		private static readonly IntPtr NativeFieldInfoPtr_SteamParticles;

		// Token: 0x04007960 RID: 31072
		private static readonly IntPtr NativeFieldInfoPtr_SteamColor;

		// Token: 0x04007961 RID: 31073
		private static readonly IntPtr NativeFieldInfoPtr_SteamAlpha;

		// Token: 0x04007962 RID: 31074
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007963 RID: 31075
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04007964 RID: 31076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
