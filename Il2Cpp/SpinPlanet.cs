using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000023 RID: 35
	public class SpinPlanet : MonoBehaviour
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00078D90 File Offset: 0x00076F90
		// Note: this type is marked as 'beforefieldinit'.
		static SpinPlanet()
		{
			Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpinPlanet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr);
			SpinPlanet.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr, "speed");
			SpinPlanet.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr, 100663552);
			SpinPlanet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr, 100663553);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00078DFC File Offset: 0x00076FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72729, XrefRangeEnd = 72734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinPlanet.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00078E30 File Offset: 0x00077030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72734, XrefRangeEnd = 72735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpinPlanet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinPlanet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003857 File Offset: 0x00001A57
		public SpinPlanet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00078E6C File Offset: 0x0007706C
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00003860 File Offset: 0x00001A60
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpinPlanet.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpinPlanet.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
